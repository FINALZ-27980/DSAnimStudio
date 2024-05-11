using ImGuiNET;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAnimStudio.ImguiOSD
{
    public static class MenuBar
    {
        public static TaeEditor.TaeEditorScreen Tae => Main.TAE_EDITOR;

        public static bool IsAnyMenuOpen = false;
        public static bool IsAnyMenuOpenChanged = false;
        private static bool prevIsAnyMenuOpen = false;

        public static void BuildMenuBar()
        {
            bool isAnyMenuExpanded = false;

            if (ImGui.BeginMenu("文件"))
            {
                isAnyMenuExpanded = true;

                bool clickedOpen = ClickItem("打开已有anibnd.dcx文件");
                ImGui.Separator();
                bool clickedOpenFromArchives = ClickItem("打开anibnd.dcx文件，未解包anibnd.dcx文件时使用");
                ImGui.Separator();
                bool isRecentFilesExpanded = ImGui.BeginMenu("最近打开的文件");
                if (isRecentFilesExpanded)
                {
                    if (ClickItem("清除打开文件记录"))
                    {
                        DialogManager.AskForMultiChoice("清除打开文件记录",
                            "是否清除打开文件记录?", (cancelType, answer) =>
                            {
                                if (answer == "YES")
                                {
                                    lock (Main.Config._lock_ThreadSensitiveStuff)
                                    {
                                        Main.Config.RecentFilesList.Clear();
                                    }
                                    Main.SaveConfig();
                                }
                            }, Dialog.CancelTypes.Combo_ClickTitleBarX_PressEscape, "确定", "取消");
                    }

                    ImGui.Separator();

                    try
                    {
                        string fileOpened = null;
                        string fileOpened_Model = null;
                        lock (Main.Config._lock_ThreadSensitiveStuff)
                        {
                            foreach (var f in Main.Config.RecentFilesList)
                            {
                                if (fileOpened == null && ClickItem(f.TaeFile))
                                {
                                    fileOpened = f.TaeFile;
                                    fileOpened_Model = f.ModelFile;
                                }
                            }
                        }

                        if (fileOpened != null)
                        {
                            Main.MainThreadLazyDispatch(() =>
                            {
                                Tae.DirectOpenFile(fileOpened, fileOpened_Model);
                            });
                            
                        }
                    }
                    catch
                    {

                    }

                    ImGui.EndMenu();
                }

                ImGui.Separator();
                bool clickedReloadGameParam = ClickItem("重载param和fmg（参数和文本）", enabled: Tae.IsFileOpen);
                ImGui.Separator();
                bool clickedSave = ClickItem("保存", enabled: Tae.IsFileOpen && Tae.IsModified, shortcut: "Ctrl+S");
                bool clickedSaveAs = ClickItem("另存为", enabled: Tae.IsFileOpen, shortcut: "Ctrl+Shift+S");
                bool extensiveBackupsValue = Checkbox(
                    "每次保存时都生成一个新备份",
                    Tae.Config.ExtensiveBackupsEnabled);
                bool clickedExportTAE = ClickItem("导出包含当前动作的TAE文件（一般用不上）", enabled: Tae.SelectedTae != null);
                //ImGui.Separator();
                //var prevValueSaveAdditionalEventRowInfoToLegacyGames = Main.Config.SaveAdditionalEventRowInfoToLegacyGames;
                //var nextValueSaveAdditionalEventRowInfoToLegacyGames = Checkbox("Save Row Data To Legacy Games",
                //    prevValueSaveAdditionalEventRowInfoToLegacyGames, enabled: true,
                //    shortcut: "DeS/DS1 Only");
                //if (nextValueSaveAdditionalEventRowInfoToLegacyGames != prevValueSaveAdditionalEventRowInfoToLegacyGames)
                //{
                //    if (nextValueSaveAdditionalEventRowInfoToLegacyGames)
                //    {
                //        DialogManager.AskYesNo("Warning", "This option has not been tested in the long run and may cause the game to behave " +
                //            "\nstrangely, or it may not. Are you sure you wish to use this option? " +
                //            "\nNote: effect is reversable if you run into issues.", choice =>
                //            {
                //                if (choice)
                //                {
                //                    Main.Config.SaveAdditionalEventRowInfoToLegacyGames = true;

                //                    if (GameDataManager.GameTypeUsesLegacyEmptyEventGroups)
                //                    {
                //                        Tae.StripExtraEventGroupsInAllLoadedFilesIfNeeded();
                //                    }
                //                }
                //            }, allowCancel: true, enterKeyForYes: false);
                //    }
                //    else
                //    {
                //        DialogManager.AskYesNo("Warning", "Disabling this option will IMMEDIATELY REMOVE ALL of the extra row data from all " +
                //            "\nanimations in anibnd files which utilized this option previously and make them all use the standard " +
                //            "\nautomatic row sorting, which will PERMANENTLY save into the file when resaved. " +
                //            "\nAre you sure you wish to do this?", choice =>
                //            {
                //                if (choice)
                //                {
                //                    Main.Config.SaveAdditionalEventRowInfoToLegacyGames = false;
                //                    Tae.StripExtraEventGroupsInAllLoadedFilesIfNeeded();
                //                }
                //            }, allowCancel: true, enterKeyForYes: false);
                //    }
                //}
                ImGui.Separator();
                var canReload = Tae.IsFileOpen && LiveRefresh.RequestFileReload.CanReloadEntity(Tae?.Graph?.ViewportInteractor?.CurrentModel.Name);
                bool clickedLiveRefreshNow = ClickItem($"重新加载游戏内的文件",
                    enabled: canReload, shortcut: "F5");
                bool liveRefreshOnSaveValue = Checkbox(
                    "保存时重新加载游戏内的文件\n    (如果上述选项显示为灰色，则不执行任何操作)",
                    Tae.Config.LiveRefreshOnSave);
                ImGui.NewLine();
                ImGui.Separator();
                bool clickedSaveConfigManually = ClickItem("保存当前DSA设置");
                Main.DisableConfigFileAutoSave = !Checkbox("每次改变设置后自动保存", !Main.DisableConfigFileAutoSave);
                bool clickedLoadConfigManually = ClickItem("重载DSA设置文件");

                ImGui.Separator();
                bool clickedExit = ClickItem("退出");

                // Only do the interaction layer with the main window if the recent files list isn't covering it...
                if (!isRecentFilesExpanded)
                {

                    if (clickedOpen)
                    {
                        Main.MainThreadLazyDispatch(() =>
                        {
                            Tae.File_Open();
                        });
                    }
                        

                    if (clickedOpenFromArchives)
                    {
                        Main.MainThreadLazyDispatch(() =>
                        {
                            Tae.OpenFromPackedGameArchives();
                        });
                    }
                        

                    if (clickedReloadGameParam)
                    {
                        LoadingTaskMan.DoLoadingTask("FileReloadGameParam",
                            "Reloading GameParam and FMGs...", prog =>
                            {
                                GameRoot.ReloadParams();
                                GameRoot.ReloadFmgs();
                                Tae.Graph?.ViewportInteractor?.CurrentModel?.RescanNpcParams();
                                Tae.Graph?.ViewportInteractor?.OnScrubFrameChange();
                            }, disableProgressBarByDefault: true);
                    }

                    if (clickedSave)
                    {
                        Main.MainThreadLazyDispatch(() =>
                        {
                            Tae.SaveCurrentFile();
                        });
                    }
                        

                    if (clickedSaveAs)
                    {
                        Main.MainThreadLazyDispatch(() =>
                        {
                            Tae.File_SaveAs();
                        });
                        
                    }

                    if (clickedExportTAE)
                    {
                        Main.MainThreadLazyDispatch(() =>
                        {
                            Tae.Tools_ExportCurrentTAE();
                        });
                        
                    }

                    if (clickedLiveRefreshNow)
                        Tae.LiveRefresh();

                    Tae.Config.LiveRefreshOnSave = liveRefreshOnSaveValue;
                    Tae.Config.ExtensiveBackupsEnabled = extensiveBackupsValue;

                    if (clickedSaveConfigManually)
                    {
                        Main.SaveConfig(isManual: true);
                    }

                    if (clickedLoadConfigManually)
                    {
                        Main.LoadConfig(isManual: true);
                    }

                    if (clickedExit)
                        Main.WinForm.Close();
                }

                ImGui.EndMenu();
            }

            if (ImGui.BeginMenu("编辑"))
            {
                isAnyMenuExpanded = true;

                if (ClickItem("撤销", Tae.UndoMan?.CanUndo ?? false, "Ctrl+Z"))
                    Tae.UndoMan?.Undo();
                if (ClickItem("恢复", Tae.UndoMan?.CanRedo ?? false, "Ctrl+Y"))
                    Tae.UndoMan?.Redo();

                ImGui.Separator();

                if (ClickItem("折叠所有TAE动画", Tae.IsFileOpen))
                    Tae.SetAllTAESectionsCollapsed(true);
                if (ClickItem("展开所有TAE动画", Tae.IsFileOpen))
                    Tae.SetAllTAESectionsCollapsed(false);

                ImGui.Separator();

                if (ClickItem("寻找动作ID...", Tae.IsFileOpen, "Ctrl+F"))
                    Tae.ShowDialogFind();

                if (ClickItem("转到动作ID...", Tae.IsFileOpen, "Ctrl+G"))
                    Tae.ShowDialogGotoAnimID();

                if (ClickItem("转到动作部分ID...", Tae.IsFileOpen, "Ctrl+H"))
                    Tae.ShowDialogGotoAnimSectionID();

                if (ClickItem("导入指定的动作ID", Tae.IsFileOpen, "Ctrl+I"))
                    Tae.ShowDialogImportFromAnimID();

                ImGui.Separator();

                if (ClickItem("更改所选事件的类型", Tae.IsFileOpen && Tae.SingleEventBoxSelected, "F1"))
                    Tae.ChangeTypeOfSelectedEvent();

                if (ClickItem("导出当前的动作名称", Tae.IsFileOpen, "F2"))
                    Tae.ShowDialogChangeAnimName();

                if (ClickItem("转换当前的动作属性", Tae.IsFileOpen, "F3"))
                    Tae.ShowDialogEditCurrentAnimInfo();

                if (ClickItem("转到所属事件的原动作", Tae.IsFileOpen, "F4"))
                    Tae.GoToEventSource();

                if (ClickItem("导入动作", Tae.IsFileOpen, "Insert"))
                    Tae.DuplicateCurrentAnimation();

                ImGui.EndMenu();
            }

            if (ImGui.BeginMenu("词条显示设置"))
            {
                isAnyMenuExpanded = true;

                Tae.Config.EventSnapType = EnumSelectorItem<TaeEditor.TaeConfigFile.EventSnapTypes>("调整词条帧数标准",
                    Tae.Config.EventSnapType, new Dictionary<TaeEditor.TaeConfigFile.EventSnapTypes, string>
                {
                        { TaeEditor.TaeConfigFile.EventSnapTypes.None, "None" },
                        { TaeEditor.TaeConfigFile.EventSnapTypes.FPS30, "30 FPS (used by FromSoft)" },
                        { TaeEditor.TaeConfigFile.EventSnapTypes.FPS60, "60 FPS" },
                }, enabled: Tae.IsFileOpen);

                ImGui.Separator();

                //Tae.Config.IsNewGraphVisiMode = Checkbox("Use New Graph Design", Tae.Config.IsNewGraphVisiMode);
                Tae.Config.EnableFancyScrollingStrings = Checkbox("启用词条文本滚动", Tae.Config.EnableFancyScrollingStrings);
                Tae.Config.FancyScrollingStringsScrollSpeed = FloatSlider("词条文本滚动速度", Tae.Config.FancyScrollingStringsScrollSpeed, 1, 256, "%f 帧/秒");
                ImGui.Separator();
                Tae.Config.AutoCollapseAllTaeSections = Checkbox("启动时折叠所有TAE", Tae.Config.AutoCollapseAllTaeSections);
                ImGui.Separator();
                Tae.Config.AutoScrollDuringAnimPlayback = Checkbox("播放动作时词条窗口跟随滚动", Tae.Config.AutoScrollDuringAnimPlayback);
                ImGui.Separator();
                Tae.Config.SoloHighlightEventOnHover = Checkbox("悬停在词条上是高亮此词条，其他词条会变暗", Tae.Config.SoloHighlightEventOnHover);
                Tae.Config.ShowEventHoverInfo = Checkbox("悬停时显示词条详细数据信息", Tae.Config.ShowEventHoverInfo);

                ImGui.EndMenu();
            }

            if (ImGui.BeginMenu("效果开关"))
            {
                try
                {
                    foreach (var thing in TaeEditor.TaeEventSimulationEnvironment.AllEntryDisplayNames)
                    {
                        Main.Config.SetEventSimulationEnabled(thing.Key,
                            Checkbox(thing.Value, Main.Config.GetEventSimulationEnabled(thing.Key)));
                    }

                }
                catch
                {

                }
                finally
                {
                    ImGui.EndMenu();
                }
                
            }

            if (ImGui.BeginMenu("动画播放设置"))
            {
                isAnyMenuExpanded = true;

                Tae.Config.LockFramerateToOriginalAnimFramerate = Checkbox(
                    "锁定HKS动画帧数", Tae.Config.LockFramerateToOriginalAnimFramerate,
                    shortcut: Tae.PlaybackCursor != null
                    ? $"({((int)Math.Round(Tae.PlaybackCursor.CurrentSnapFPS))} FPS)" : null);

                TaeEditor.TaePlaybackCursor.GlobalBasePlaybackSpeed = FloatSlider("播放速度",
                    TaeEditor.TaePlaybackCursor.GlobalBasePlaybackSpeed * 100f, 0, 100, "%.2f %%") / 100f;



                ImGui.Separator();

                Tae.Config.EnableAnimRootMotion = Checkbox(
                    "启用根运动（根运动是实际上的位置？有些看似在空中的动作跨不过障碍物是因为根运动实际还在地上）", Tae.Config.EnableAnimRootMotion);

                Tae.Config.RootMotionTranslationMultiplierXZ = FloatSlider("根运动平移XZ轴",
                    Tae.Config.RootMotionTranslationMultiplierXZ, 0, 20, "%.2f");
                Tae.Config.RootMotionTranslationPowerXZ = FloatSlider("根运动平移最大的XZ轴",
                   Tae.Config.RootMotionTranslationPowerXZ, 0, 2, "%.2f");

                Tae.Config.RootMotionTranslationMultiplierY = FloatSlider("根运动平移Y轴",
                    Tae.Config.RootMotionTranslationMultiplierY, 0, 1, "%.2f");
                Tae.Config.RootMotionTranslationPowerY = FloatSlider("根运动平移最大的Y轴",
                    Tae.Config.RootMotionTranslationPowerY, 0, 1, "%.2f");

                Tae.Config.RootMotionRotationMultiplier = FloatSlider("根运动的旋转",
                    Tae.Config.RootMotionRotationMultiplier, 0, 1, "%.2f");
                Tae.Config.RootMotionRotationPower = FloatSlider("根运动的最大旋转",
                    Tae.Config.RootMotionRotationPower, 0, 1, "%.2f");

                ImGui.Separator();

                if (ClickItem($"镜头跟随类型: 根运动", shortcut: $"", shortcutColor: Color.Cyan, selected: Tae.Config.CameraFollowType == TaeEditor.TaeConfigFile.CameraFollowTypes.RootMotion))
                {
                    Tae.Config.CameraFollowType = TaeEditor.TaeConfigFile.CameraFollowTypes.RootMotion;
                }

                if (ClickItem($"镜头跟随类型: 身体的dummy点", shortcut: $"", shortcutColor: Color.Cyan, selected: Tae.Config.CameraFollowType == TaeEditor.TaeConfigFile.CameraFollowTypes.BodyDummyPoly))
                {
                    Tae.Config.CameraFollowType = TaeEditor.TaeConfigFile.CameraFollowTypes.BodyDummyPoly;
                }



                Tae.Config.CameraFollowDummyPolyID = IntItem("dummy点对应的ID值", Tae.Config.CameraFollowDummyPolyID);

                ImGui.Separator();

                Tae.Config.CameraFollowsRootMotionZX = Checkbox(
                    "镜头跟随 - 平移ZX轴", Tae.Config.CameraFollowsRootMotionZX, shortcut: "", shortcutColor: Color.White);

                Tae.Config.CameraFollowsRootMotionZX_Interpolation = FloatSlider(
                    "镜头跟随 - 平移ZX轴 - 插值", Tae.Config.CameraFollowsRootMotionZX_Interpolation, 
                    0, 1, "%f", power: 2f);

                ImGui.Separator();

                Tae.Config.CameraFollowsRootMotionY = Checkbox(
                    "镜头跟随 - 平移Y轴", Tae.Config.CameraFollowsRootMotionY, shortcut: "", shortcutColor: Color.White);

                Tae.Config.CameraFollowsRootMotionY_Interpolation = FloatSlider(
                    "镜头跟随 - 平移Y轴 - 插值", Tae.Config.CameraFollowsRootMotionY_Interpolation,
                    0, 1, "%f", power: 2f);

                ImGui.Separator();

                Tae.Config.CameraFollowsRootMotionRotation = Checkbox(
                    "镜头跟随 - 旋转", Tae.Config.CameraFollowsRootMotionRotation, shortcut: "", shortcutColor: Color.White);

                Tae.Config.CameraFollowsRootMotionRotation_Interpolation = FloatSlider(
                    "镜头跟随 - 旋转 - 插值", Tae.Config.CameraFollowsRootMotionRotation_Interpolation,
                    0, 1, "%f", power: 2f);

                ImGui.Separator();

                Tae.Config.WrapRootMotion = Checkbox(
                    "防止根运动接触网格末端", Tae.Config.WrapRootMotion);

                ImGui.EndMenu();
            }

            if (GameRoot.GameTypeUsesWwise)
            {
                if (ImGui.BeginMenu("Wwise声效设置"))
                {
                    DoWindow(OSD.WindowWwiseManager);
                    ImGui.EndMenu();
                }
            }
            else
            {
                OSD.WindowWwiseManager.IsOpen = false;
                if (ImGui.BeginMenu("FMOD声效设置"))
                {
                    isAnyMenuExpanded = true;

                    if (ClickItem("重新初始化", !FmodManager.IsInitialized))
                    {
                        FmodManager.InitTest();
                        Tae.Graph?.ViewportInteractor?.LoadSoundsForCurrentModel();
                    }

                    ImGui.Separator();

                    if (ClickItem("重载所有声音", FmodManager.IsInitialized))
                    {
                        FmodManager.Purge();
                        FmodManager.LoadMainFEVs();
                        Tae.Graph?.ViewportInteractor?.LoadSoundsForCurrentModel();
                    }

                    ImGui.Separator();

                    if (ClickItem("停止所有声音（但实测好像没什么效果？）", FmodManager.IsInitialized, "Escape"))
                    {
                        SoundManager.StopAllSounds();
                    }

                    if (ImGui.BeginMenu("加载其它声效库（其它角色或者环境音之类）", enabled: FmodManager.IsInitialized &&
                        FmodManager.MediaPath != null))
                    {
                        var fevFiles = GameData.SearchFiles("/sound", @".*\.fev");

                        for (int i = 0; i < fevFiles.Count; i++)
                        {
                            var shortName = Path.GetFileNameWithoutExtension(fevFiles[i]);
                            if (ClickItem(shortName, shortcut: FmodManager.LoadedFEVs.Contains(shortName) ? "(Loaded)" : null))
                            {
                                int underscoreIndex = shortName.IndexOf('_');
                                if (underscoreIndex >= 0)
                                    shortName = shortName.Substring(Math.Min(underscoreIndex + 1, shortName.Length - 1));
                                FmodManager.LoadInterrootFEV(shortName);
                            }
                        }



                        ImGui.EndMenu();
                    }

                    ImGui.Separator();

                    //FmodManager.ArmorMaterial = EnumSelectorItem("Player Armor Material",
                    //        FmodManager.ArmorMaterial, new Dictionary<FmodManager.ArmorMaterialType, string>
                    //    {
                    //            { FmodManager.ArmorMaterialType.Plates, "Platemail" },
                    //            { FmodManager.ArmorMaterialType.Chains, "Chainmail" },
                    //            { FmodManager.ArmorMaterialType.Cloth, "Cloth" },
                    //            { FmodManager.ArmorMaterialType.None, "Naked" },
                    //    });

                    if (ImGui.BeginMenu("脚步声使用材质（type8的128词条是脚步声，会根据材质播放声音）"))
                    {
                        foreach (var mat in FmodManager.FloorMaterialNames)
                        {
                            if (ClickItem($"Material {mat.Key:D2}", shortcut: mat.Value, shortcutColor: Color.White, selected: mat.Key == FmodManager.FloorMaterial))
                            {
                                FmodManager.FloorMaterial = mat.Key;
                            }
                        }

                        ImGui.EndMenu();
                    }

                    ImGui.EndMenu();
                }

            }

            //TODO - HELP. BETTER.

            void DoWindow(Window w)
            {
                w.IsOpen = Checkbox($"{w.Title}###Checkbox|{w.ImguiTag}", w.IsOpen);
            }

            bool clicked_Tools_ComboViewer = false;

#if DEBUG
            bool clicked_Tools_ScanForUnusedAnimations = false;
#endif

            bool clicked_Tools_ExportSkeletonAndAnims = false;
            bool clicked_Tools_ExportEventTextFile = false;
            bool clicked_Tools_AnimNameExport = false;
            bool clicked_Tools_AnimNameImport = false;
            //bool clicked_Tools_AnimationImporter = false;
            bool clicked_Tools_ManageTaeSections = false;
            bool clicked_Tools_ManageAnimationFiles = false;

            if (ImGui.BeginMenu("工具"))
            {
                isAnyMenuExpanded = true;

                if (ClickItem("连招预览", shortcut: "F8"))
                    clicked_Tools_ComboViewer = true;

#if DEBUG
                if (ClickItem("扫描未使用的动画", shortcut: "[DEBUG]",
                    textColor: Color.Red, shortcutColor: Color.Red))
                    clicked_Tools_ScanForUnusedAnimations = true;
#endif

                ImGui.Separator();

                if (ClickItem("导出骨骼动画...", enabled: Tae?.IsFileOpen == true && !LoadingTaskMan.AnyTasksRunning()))
                    clicked_Tools_ExportSkeletonAndAnims = true;

                ImGui.Separator();

                if (ClickItem("导出所有词条数据为txt文本...", enabled: Tae?.IsFileOpen == true && !LoadingTaskMan.AnyTasksRunning()))
                    clicked_Tools_ExportEventTextFile = true;

                ImGui.Separator();

                if (ClickItem("导出所有注释...", enabled: Tae?.IsFileOpen == true && !LoadingTaskMan.AnyTasksRunning()))
                    clicked_Tools_AnimNameExport = true;

                if (ClickItem("导入注释...", enabled: Tae?.IsFileOpen == true && !LoadingTaskMan.AnyTasksRunning()))
                    clicked_Tools_AnimNameImport = true;

                //ImGui.Separator();

                //if (ClickItem("Open Animation Importer"))
                //    clicked_Tools_AnimationImporter = true;

                ImGui.Separator();

                Main.Config.EnableGameDataIOLogging = Checkbox(
                    "启用GameData日志",
                    Main.Config.EnableGameDataIOLogging);

                //ImGui.Separator();

                //if (ClickItem("Manage TAE Sections...", enabled: Tae?.IsFileOpen == true && !LoadingTaskMan.AnyTasksRunning()))
                //    clicked_Tools_ManageTaeSections = true;

                //if (ClickItem("Manage Animation Files...", enabled: Tae?.IsFileOpen == true && !LoadingTaskMan.AnyTasksRunning()))
                //    clicked_Tools_ManageAnimationFiles = true;

                ImGui.EndMenu();
            }

            if (ImGui.BeginMenu("界面设置"))
            {
                DoWindow(OSD.WindowEntitySettings);
                //DoWindow(OSD.WindowEditPlayerEquip); //handled in player menu
                //DoWindow(OSD.WindowHelp); //handled in help menu
                DoWindow(OSD.WindowSceneManager);
                DoWindow(OSD.WindowToolbox);

                if (OSD.EnableDebugMenu)
                {
                    ImGui.Separator();
                    DoWindow(OSD.WindowDebug);
                }
                else
                {
                    OSD.WindowDebug.IsOpen = false;
                }

                ImGui.EndMenu();
            }

            void openSite(string url)
            {
                Main.MainThreadLazyDispatch(() =>
                {
                    var psi = new ProcessStartInfo
                    {
                        FileName = url,
                        UseShellExecute = true
                    };
                    Process.Start(psi);
                });
                
            }

            ImGui.PushStyleColor(ImGuiCol.Text, Color.Cyan.ToNVector4());
            bool helpMenu = ImGui.BeginMenu("帮助");
            ImGui.PopStyleColor();
            if (helpMenu)
            {
                isAnyMenuExpanded = true;

                OSD.WindowHelp.IsOpen = Checkbox("显示基本帮助窗口", OSD.WindowHelp.IsOpen, textColor: Color.White);

                ImGui.Separator();

                if (ClickItem("Souls Modding Discord Server", textColor: Color.White,
                   shortcut: "?ServerName? (https://discord.gg/mT2JJjx)", shortcutColor: Color.Cyan))
                    openSite("https://discord.gg/mT2JJjx");

                if (ClickItem("My Discord Server (Less Active)", textColor: Color.White,
                    shortcut: "Meowmaritus Zone (https://discord.gg/J79XMgR)", shortcutColor: Color.Cyan))
                    openSite("https://discord.gg/J79XMgR");

                ImGui.EndMenu();
            }

            ImGui.PushStyleColor(ImGuiCol.Text, Color.Lime.ToNVector4());
            bool supportMenu = ImGui.BeginMenu("赞助作者");
            ImGui.PopStyleColor();

            

            if (supportMenu)
            {
                isAnyMenuExpanded = true;

                if (ClickItem("On Patreon...", textColor: Color.Lime,
                    shortcut: "(https://www.patreon.com/Meowmaritus)", shortcutColor: Color.Lime))
                    openSite("https://www.patreon.com/Meowmaritus");

                if (ClickItem("On Paypal...", textColor: Color.Lime,
                    shortcut: "(https://paypal.me/Meowmaritus)", shortcutColor: Color.Lime))
                    openSite("https://paypal.me/Meowmaritus");

                if (ClickItem("On Ko-fi...", textColor: Color.Lime,
                    shortcut: "(https://ko-fi.com/meowmaritus)", shortcutColor: Color.Lime))
                    openSite("https://ko-fi.com/meowmaritus");

                ImGui.EndMenu();
            }

            IsAnyMenuOpen = isAnyMenuExpanded;

            IsAnyMenuOpenChanged = IsAnyMenuOpen != prevIsAnyMenuOpen;

            prevIsAnyMenuOpen = IsAnyMenuOpen;

            if (clicked_Tools_ComboViewer)
            {
                Main.MainThreadLazyDispatch(() =>
                {
                    Tae.ShowComboMenu();
                });
                
            }
#if DEBUG
            else if (clicked_Tools_ScanForUnusedAnimations)
            {
                Main.MainThreadLazyDispatch(() =>
                {
                    Tae.Tools_ScanForUnusedAnimations();
                });
                
            }
#endif
            else if (clicked_Tools_ExportSkeletonAndAnims)
            {
                Main.MainThreadLazyDispatch(() =>
                {
                    Tae.ShowExportAllAnimsMenu();
                });
                
            }
            else if (clicked_Tools_ExportEventTextFile)
            {
                Main.MainThreadLazyDispatch(() =>
                {
                    Tae.ShowExportAllEventsToTextFileDialog();
                });
                
            }
            else if (clicked_Tools_AnimNameExport)
            {
                Main.MainThreadLazyDispatch(() =>
                {
                    Tae.ShowExportAllAnimNamesDialog();
                });
                
            }
            else if (clicked_Tools_AnimNameImport)
            {
                Main.MainThreadLazyDispatch(() =>
                {
                    Tae.ShowImportAllAnimNamesDialog();
                });
                
            }
            //else if (clicked_Tools_ManageTaeSections)
            //{
            //    Main.MainThreadLazyDispatch(() =>
            //    {
            //        Tae.ShowManageTaeSectionsDialog();
            //    });
                
            //}
            //else if (clicked_Tools_ManageAnimationFiles)
            //{
            //    Main.MainThreadLazyDispatch(() =>
            //    {
            //        Tae.ShowManageAnimationsDialog();
            //    });
                
            //}
            //else if (clicked_Tools_AnimationImporter)
            //{
            //    Tae.BringUpImporter_FBXAnim();
            //}
        }

        private static float FloatSlider(string name, float currentValue, float min, float max, string format = "%f", float power = 1)
        {
            float v = currentValue;
            ImGui.SliderFloat(name, ref v, min, max, format, ImGuiSliderFlags.None);
            return v;
        }

        public static T EnumSelectorItem<T>(string itemName, T currentValue, Dictionary<T, string> entries = null, bool enabled = true)
            where T : Enum
        {
            if (ImGui.BeginMenu(itemName, enabled))
            {
                foreach (var kvp in entries)
                {
                    ImGui.MenuItem(kvp.Value, null, currentValue.Equals(kvp.Key));
                    if (ImGui.IsItemClicked())
                    {
                        currentValue = kvp.Key;
                        break;
                    }
                }

                ImGui.EndMenu();
            }

            return currentValue;
        }

        public static bool ClickItem(string text, bool enabled = true, string shortcut = null,
            Color? textColor = null, Color? shortcutColor = null, bool selected = false)
        {
            if (textColor != null)
                ImGui.PushStyleColor(ImGuiCol.Text, textColor.Value.ToNVector4());
            if (shortcutColor != null)
                ImGui.PushStyleColor(ImGuiCol.TextDisabled, shortcutColor.Value.ToNVector4());

            if (shortcut == null)
                ImGui.MenuItem(text, null, selected, enabled: enabled);
            else
                ImGui.MenuItem(text, shortcut, selected, enabled: enabled);


            //var textLineCount = text.Split('\n').Length;
            //if (textLineCount > 1)
            //{
            //    for (int i = 1; i < textLineCount; i++)
            //        ImGui.NewLine();
            //}

            if (textColor != null)
                ImGui.PopStyleColor();
            if (shortcutColor != null)
                ImGui.PopStyleColor();
            

            bool wasClicked = false;

            if (enabled)
                wasClicked = ImGui.IsItemClicked();

            return enabled && wasClicked;
        }

        public static int IntItem(string text, int currentValue)
        {
            int v = currentValue;
            ImGui.InputInt(text, ref v);
            return v;
        }


        public static bool Checkbox(string text, bool currentValue, bool enabled = true,
            string shortcut = null, Color? textColor = null, Color? shortcutColor = null)
        {
            bool v = currentValue;
            if (textColor != null)
                ImGui.PushStyleColor(ImGuiCol.Text, textColor.Value.ToNVector4());
            if (shortcutColor != null)
                ImGui.PushStyleColor(ImGuiCol.TextDisabled, shortcutColor.Value.ToNVector4());
            ImGui.MenuItem(text, shortcut, ref v, enabled: enabled);
            if (textColor != null)
                ImGui.PopStyleColor();
            if (shortcutColor != null)
                ImGui.PopStyleColor();
            return v;
        }

        public static bool CheckboxBig(string text, bool currentValue)
        {
            bool v = currentValue;
            ImGui.Checkbox(text, ref v);
            return v;
        }
    }
}
