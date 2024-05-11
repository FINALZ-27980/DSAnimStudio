using ImGuiNET;
using SoulsAssetPipeline.Animation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAnimStudio.ImguiOSD
{
    public abstract partial class Dialog
    {
        public class TaeAnimPropertiesEdit : Dialog
        {
            string GetAnimIDString(long id)
            {
                if (id < 0)
                    return "";

                var animID_Lower = GameRoot.GameTypeHasLongAnimIDs
                ? (id % 1_000000) : (id % 1_0000);

                var animID_Upper = GameRoot.GameTypeHasLongAnimIDs
                    ? (id / 1_000000) : (id / 1_0000);

                string curIDText;
                if (GameRoot.GameTypeHasLongAnimIDs)
                {
                    bool ds2Meme = GameRoot.CurrentAnimIDFormatType == GameRoot.AnimIDFormattingType.aXX_YY_ZZZZ;
                    if (ds2Meme)
                    {
                        curIDText = $"a{(animID_Upper):D2}_{animID_Lower:D6}";
                        curIDText = curIDText.Insert(curIDText.Length - 4, "_");
                    }
                    else
                    {
                        curIDText = $"a{(animID_Upper):D3}_{animID_Lower:D6}";
                    }
                }
                else
                {
                    curIDText = $"a{(animID_Upper):D2}_{animID_Lower:D4}";
                }

                return curIDText;
            }

            public string TaeAnimID_String;
            public string TaeAnimID_Error;
            public long? TaeAnimID_Value;

            public string ImportFromAnimID_String;
            public string ImportFromAnimID_Error;
            public int? ImportFromAnimID_Value;

            public string TaeAnimName;
            public TAE.Animation.AnimMiniHeader TaeAnimHeader;
            public bool WasAnimDeleted = false;

            public bool IsMultiTaeSubID = false;

            public TAE.Animation OriginalAnimation;

            public bool AnyUnsavedChanges()
            {
                if (OriginalAnimation.MiniHeader is TAE.Animation.AnimMiniHeader.ImportOtherAnim origAsImportOtherAnim &&
                    TaeAnimHeader is TAE.Animation.AnimMiniHeader.ImportOtherAnim newAsImportOtherAnim)
                {
                    if (origAsImportOtherAnim.ImportFromAnimID != newAsImportOtherAnim.ImportFromAnimID
                        || origAsImportOtherAnim.Unknown != newAsImportOtherAnim.Unknown)
                        return true;
                }
                else if (OriginalAnimation.MiniHeader is TAE.Animation.AnimMiniHeader.Standard origAsStandard &&
                    TaeAnimHeader is TAE.Animation.AnimMiniHeader.Standard newAsStandard)
                {
                    if (origAsStandard.ImportsHKX != newAsStandard.ImportsHKX
                        || origAsStandard.IsLoopByDefault != newAsStandard.IsLoopByDefault
                        || origAsStandard.AllowDelayLoad != newAsStandard.AllowDelayLoad
                        || origAsStandard.ImportHKXSourceAnimID != newAsStandard.ImportHKXSourceAnimID)
                        return true;
                }
                else
                {
                    return true;
                }

                if (OriginalAnimation.ID != TaeAnimID_Value || OriginalAnimation.AnimFileName != TaeAnimName)
                    return true;

                return false;
            }

            public TaeAnimPropertiesEdit(TAE.Animation anim, bool isMultiTaeSubID)
            {
                Title = "转换当前的动作属性";

                IsMultiTaeSubID = isMultiTaeSubID;

                TaeAnimID_String = IsMultiTaeSubID ? anim.ID.ToString() : GetAnimIDString(anim.ID);
                TaeAnimID_Value = anim.ID;
                OriginalAnimation = anim;
                TaeAnimName = anim.AnimFileName;
                if (anim.MiniHeader is TAE.Animation.AnimMiniHeader.ImportOtherAnim asImportOtherAnim)
                {
                    TaeAnimHeader = new TAE.Animation.AnimMiniHeader.ImportOtherAnim()
                    {
                        ImportFromAnimID = asImportOtherAnim.ImportFromAnimID,
                        Unknown = asImportOtherAnim.Unknown,
                    };
                    ImportFromAnimID_String = GetAnimIDString(asImportOtherAnim.ImportFromAnimID);
                    ImportFromAnimID_Value = asImportOtherAnim.ImportFromAnimID;
                }
                else if (anim.MiniHeader is TAE.Animation.AnimMiniHeader.Standard asStandard)
                {
                    TaeAnimHeader = new TAE.Animation.AnimMiniHeader.Standard()
                    {
                        AllowDelayLoad = asStandard.AllowDelayLoad,
                        ImportHKXSourceAnimID = asStandard.ImportHKXSourceAnimID,
                        ImportsHKX = asStandard.ImportsHKX,
                        IsLoopByDefault = asStandard.IsLoopByDefault,
                    };
                    ImportFromAnimID_String = GetAnimIDString(asStandard.ImportHKXSourceAnimID);
                    ImportFromAnimID_Value = asStandard.ImportHKXSourceAnimID;
                }
            }

            protected override void BuildInsideOfWindow()
            {
                if (TaeAnimID_Value != null)
                    TaeAnimID_Error = null;

                if (ImportFromAnimID_Value != null)
                    ImportFromAnimID_Error = null;

                bool isCurrentlyStandard = TaeAnimHeader.Type == TAE.Animation.MiniHeaderType.Standard;
                bool isCurrentlyImportOther = TaeAnimHeader.Type == TAE.Animation.MiniHeaderType.ImportOtherAnim;

                if (TaeAnimID_Value == null)
                    ImGui.PushStyleColor(ImGuiCol.Text, new System.Numerics.Vector4(1, 0, 0, 1));
                ImGui.InputText("动作ID", ref TaeAnimID_String, 256);
                if (ImGui.IsItemHovered() && TaeAnimID_Error != null)
                    ImGui.SetTooltip(TaeAnimID_Error);
                if (TaeAnimID_Value == null)
                    ImGui.PopStyleColor();
                if (string.IsNullOrWhiteSpace(TaeAnimID_String))
                {
                    TaeAnimID_Value = null;
                    TaeAnimID_Error = "动作实体ID必须有效";
                }
                else if (long.TryParse(TaeAnimID_String.Replace("a", "").Replace("A", "").Replace("_", ""), out long animIdParsed))
                {
                    if (IsMultiTaeSubID && animIdParsed < 0)
                    {
                        TaeAnimID_Error = "Animation sub-ID cannot be a negative value.";
                        TaeAnimID_Value = null;
                    }
                    else if (IsMultiTaeSubID && animIdParsed > (GameRoot.GameTypeHasLongAnimIDs ? 999999 : 9999))
                    {
                        TaeAnimID_Error = $"Animation sub-ID cannot be so high it overflows into the next category (over {(GameRoot.GameTypeHasLongAnimIDs ? 999999 : 9999)} for {GameRoot.GameTypeName}).";
                        TaeAnimID_Value = null;
                    }
                    else
                    {
                        TaeAnimID_Value = animIdParsed;
                    }
                    
                }
                else
                {
                    TaeAnimID_Value = null;

                    if (IsMultiTaeSubID)
                    {
                        TaeAnimID_Error = "Not a valid integer.";
                    }
                    else
                    {
                        if (GameRoot.CurrentAnimIDFormatType == GameRoot.AnimIDFormattingType.aXXX_YYYYYY)
                            TaeAnimID_Error = "Invalid ID specified. Enter an ID in either 'aXXX_YYYYYY' format or 'XXXYYYYYY' format.";
                        else if (GameRoot.CurrentAnimIDFormatType == GameRoot.AnimIDFormattingType.aXX_YY_ZZZZ)
                            TaeAnimID_Error = "Invalid ID specified. Enter an ID in either 'aXX_YY_ZZZZ' format or 'XXYYZZZZ' format.";
                        else if (GameRoot.CurrentAnimIDFormatType == GameRoot.AnimIDFormattingType.aXX_YYYY)
                            TaeAnimID_Error = "Invalid ID specified. Enter an ID in either 'aXX_YYYY' format or 'XXYYYY' format.";
                        else
                            throw new NotImplementedException();
                    }

                    
                }

                ImGui.Separator();

                ImGui.InputText("动作名称（例：aXXX_XXXXXX）", ref TaeAnimName, 256);

                ImGui.Separator();

                ImGui.Text("动作类型");

                ImGui.Indent();
                {
                    ImGui.MenuItem("导入的动作（仅限导入后的新动作）", "", isCurrentlyStandard);
                    bool clickedStandard = ImGui.IsItemClicked();

                    ImGui.MenuItem("原动作的副本", "", TaeAnimHeader.Type == TAE.Animation.MiniHeaderType.ImportOtherAnim);
                    bool clickedImportOther = ImGui.IsItemClicked();

                    if (clickedStandard && !isCurrentlyStandard)
                    {
                        DialogManager.AskForMultiChoice("修改动作类型",
                            "警告：如果修改动作类型, TAE动画将事件将重置", 
                            (cancelType, answer) =>
                            {
                                if (cancelType != CancelTypes.None)
                                    return;

                                if (answer == "YES")
                                {
                                    TaeAnimHeader = new TAE.Animation.AnimMiniHeader.Standard();
                                }
                            }, CancelTypes.Combo_ClickTitleBarX_PressEscape, "是", "否");
                    }
                    else if (clickedImportOther && !isCurrentlyImportOther)
                    {
                        DialogManager.AskForMultiChoice("修改动作类型",
                            "警告：如果修改动作类型, TAE动画将事件将重置", 
                            (cancelType, answer) =>
                            {
                                if (cancelType != CancelTypes.None)
                                    return;

                                if (answer == "YES")
                                {
                                    TaeAnimHeader = new TAE.Animation.AnimMiniHeader.ImportOtherAnim();
                                }
                            }, CancelTypes.Combo_ClickTitleBarX_PressEscape, "是", "否");
                    }
                }
                ImGui.Unindent();
                




                if (TaeAnimHeader is TAE.Animation.AnimMiniHeader.ImportOtherAnim asImportOtherAnim)
                {
                    ImGui.Text("动作副本属性");
                    ImGui.Indent();
                    {
                        if (ImportFromAnimID_Value == null)
                            ImGui.PushStyleColor(ImGuiCol.Text, new System.Numerics.Vector4(1, 0, 0, 1));
                        ImGui.InputText("克隆动作的实体ID", ref ImportFromAnimID_String, 256);
                        if (ImGui.IsItemHovered() && ImportFromAnimID_Error != null)
                            ImGui.SetTooltip(ImportFromAnimID_Error);
                        if (ImportFromAnimID_Value == null)
                            ImGui.PopStyleColor();
                        if (string.IsNullOrWhiteSpace(ImportFromAnimID_String))
                        {
                            ImportFromAnimID_Value = asImportOtherAnim.ImportFromAnimID = -1;
                        }
                        else if (int.TryParse(ImportFromAnimID_String.Replace("a", "").Replace("A", "").Replace("_", ""), out int importFromIdParsed))
                        {
                            ImportFromAnimID_Value = asImportOtherAnim.ImportFromAnimID = importFromIdParsed;
                        }
                        else
                        {
                            ImportFromAnimID_Value = null;
                            if (GameRoot.CurrentAnimIDFormatType == GameRoot.AnimIDFormattingType.aXXX_YYYYYY)
                                ImportFromAnimID_Error = "Invalid ID specified. Leave the box blank to specify no animation or enter an ID in either 'aXXX_YYYYYY' format or 'XXXYYYYYY' format.";
                            else if (GameRoot.CurrentAnimIDFormatType == GameRoot.AnimIDFormattingType.aXX_YY_ZZZZ)
                                ImportFromAnimID_Error = "Invalid ID specified. Leave the box blank to specify no animation or enter an ID in either 'aXX_YY_ZZZZ' format or 'XXYYZZZZ' format.";
                            else if (GameRoot.CurrentAnimIDFormatType == GameRoot.AnimIDFormattingType.aXX_YYYY)
                                ImportFromAnimID_Error = "Invalid ID specified. Leave the box blank to specify no animation or enter an ID in either 'aXX_YYYY' format or 'XXYYYY' format.";
                            else 
                                throw new NotImplementedException();
                        }

                        asImportOtherAnim.Unknown = MenuBar.IntItem("Unknown Value", asImportOtherAnim.Unknown);
                    }
                    ImGui.Unindent();
                }
                else if (TaeAnimHeader is TAE.Animation.AnimMiniHeader.Standard asStandard)
                {
                    ImGui.Text("动作原版（新导入后）属性:");
                    ImGui.Indent();
                    {
                        asStandard.ImportsHKX = MenuBar.CheckboxBig("覆盖HKX", asStandard.ImportsHKX);

                        if (ImportFromAnimID_Value == null)
                            ImGui.PushStyleColor(ImGuiCol.Text, new System.Numerics.Vector4(1, 0, 0, 1));
                        ImGui.InputText("覆盖HKX的ID", ref ImportFromAnimID_String, 256);
                        if (ImGui.IsItemHovered() && ImportFromAnimID_Error != null)
                            ImGui.SetTooltip(ImportFromAnimID_Error);
                        if (ImportFromAnimID_Value == null)
                            ImGui.PopStyleColor();
                        if (string.IsNullOrWhiteSpace(ImportFromAnimID_String))
                        {
                            ImportFromAnimID_Value = asStandard.ImportHKXSourceAnimID = -1;
                        }
                        else if (int.TryParse(ImportFromAnimID_String.Replace("a", "").Replace("A", "").Replace("_", ""), out int importFromIdParsed))
                        {
                            ImportFromAnimID_Value = asStandard.ImportHKXSourceAnimID = importFromIdParsed;
                        }
                        else
                        {
                            ImportFromAnimID_Value = null;
                            if (GameRoot.CurrentAnimIDFormatType == GameRoot.AnimIDFormattingType.aXXX_YYYYYY)
                                ImportFromAnimID_Error = "Invalid ID specified. Leave the box blank to specify no animation or enter an ID in either 'aXXX_YYYYYY' format or 'XXXYYYYYY' format.";
                            else if (GameRoot.CurrentAnimIDFormatType == GameRoot.AnimIDFormattingType.aXX_YY_ZZZZ)
                                ImportFromAnimID_Error = "Invalid ID specified. Leave the box blank to specify no animation or enter an ID in either 'aXX_YY_ZZZZ' format or 'XXYYZZZZ' format.";
                            else if (GameRoot.CurrentAnimIDFormatType == GameRoot.AnimIDFormattingType.aXX_YYYY)
                                ImportFromAnimID_Error = "Invalid ID specified. Leave the box blank to specify no animation or enter an ID in either 'aXX_YYYY' format or 'XXYYYY' format.";
                            else
                                throw new NotImplementedException();
                        }

                        asStandard.AllowDelayLoad = MenuBar.CheckboxBig("允许ANIBNDs加载延迟", asStandard.AllowDelayLoad);
                        asStandard.IsLoopByDefault = MenuBar.CheckboxBig("默认循环", asStandard.IsLoopByDefault);
                    }
                    ImGui.Unindent();
                }

                ImGui.Separator();
                ImGui.Button("删除动作");
                if (ImGui.IsItemClicked())
                {
                    DialogManager.AskForMultiChoice("永久删除动画条目？", $"是否确实要删除当前动画？\n这是无法撤消的！", (cancelType, answer) =>
                    {
                        if (answer == "YES")
                        {
                            WasAnimDeleted = true;
                            CancelType = CancelTypes.ClickedAcceptButton;
                            Dismiss();
                            DialogManager.DialogOK("Success", "Animation deleted successfully.");
                        }
                    }, CancelTypes.Combo_ClickTitleBarX_PressEscape, "是", "否");

                    
                }
                ImGui.Separator();

                ImGui.Button("取消和放弃更改");
                if (ImGui.IsItemClicked())
                {
                    CancelType = CancelTypes.ClickTitleBarX;
                    Dismiss();
                }

                if (Main.Input.KeyDown(Microsoft.Xna.Framework.Input.Keys.Escape))
                {
                    bool unsavedChanges = AnyUnsavedChanges();
                    bool forceClose = Main.Input.ShiftHeld;
                    if (!unsavedChanges || forceClose)
                    {
                        CancelType = CancelTypes.PressEscape;
                        Dismiss();
                    }
                }

                bool invalidState = (ImportFromAnimID_Value == null || TaeAnimID_Value == null);

                if (invalidState)
                    Tools.PushGrayedOut();
                ImGui.Button("应用并保存更改");
                if (invalidState)
                {
                    Tools.PopGrayedOut();
                    if (ImGui.IsItemHovered())
                    {
                        ImGui.SetTooltip("Cannot accept changes until the animation ID formatting errors (shown in red) are fixed.");
                    }
                }
                if (ImGui.IsItemClicked())
                {
                    if (!invalidState)
                    {
                        CancelType = CancelTypes.ClickedAcceptButton;
                        Dismiss();
                    }
                   
                }

                //throw new NotImplementedException();
            }
        }
    }
}
