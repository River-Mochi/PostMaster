// Localization/LocaleZH_HANT.cs
// Traditional Chinese locale zh-HANT

namespace MagicMail
{
    using System.Collections.Generic;
    using Colossal;

    /// <summary>
    /// Traditional Chinese localization source for Magic Mail [MM].</summary>
    public sealed class LocaleZH_HANT : IDictionarySource
    {
        private readonly Setting m_Setting;

        /// <summary>
        /// Constructs the Traditional Chinese locale generator.</summary>
        /// <param name="setting">Settings object used for locale IDs.</param>
        public LocaleZH_HANT(Setting setting)
        {
            m_Setting = setting;
        }

        /// <summary>
        /// Generates all Traditional Chinese localization entries for this mod.</summary>
        public IEnumerable<KeyValuePair<string, string>> ReadEntries(
            IList<IDictionaryEntryError> errors,
            Dictionary<string, int> indexCounts)
        {
            return new Dictionary<string, string>
            {
                // Mod title
                { m_Setting.GetSettingsLocaleID(), "Magic Mail [MM]" },

                // Tabs
                { m_Setting.GetOptionTabLocaleID(Setting.kActionsTab), "操作" },
                { m_Setting.GetOptionTabLocaleID(Setting.kStatusTab),  "狀態" },
                { m_Setting.GetOptionTabLocaleID(Setting.kAboutTab),   "關於" },

                // Groups (Actions tab)
                { m_Setting.GetOptionGroupLocaleID(Setting.PostOfficeGroup),          "郵局" },
                { m_Setting.GetOptionGroupLocaleID(Setting.PostVanGroup),             "郵政貨車與卡車" },
                { m_Setting.GetOptionGroupLocaleID(Setting.PostSortingFacilityGroup), "分揀設施" },
                { m_Setting.GetOptionGroupLocaleID(Setting.ResetGroup),               "重設" },

                // Groups (Status tab)
                { m_Setting.GetOptionGroupLocaleID(Setting.StatusSummaryGroup), "城市掃描" },
                { m_Setting.GetOptionGroupLocaleID(Setting.StatusActivityGroup), "最近更新" },

                // Groups (About tab)
                { m_Setting.GetOptionGroupLocaleID(Setting.kAboutInfoGroup),  "資訊" },
                { m_Setting.GetOptionGroupLocaleID(Setting.kAboutLinksGroup), "連結" },

                // ---- Post Office ----
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PO_GetLocalMail)), "修正本地郵件過低" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PO_GetLocalMail)),
                    "啟用後，如果郵件儲存量太低，會額外生成一些郵件。\n " +
                    "不會產生額外郵車；就像魔法一樣，但是真的 :)" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PO_GettingThresholdPercentage)), "本地郵件門檻" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PO_GettingThresholdPercentage)),
                    "當本地郵件低於你設定的百分比時，\n " +
                    "郵局會拉進更多本地郵件。\n" +
                    "這是相對最大儲存量的百分比。" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PO_GettingPercentage)), "本地郵件補充量" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PO_GettingPercentage)),
                    "補充本地郵件時要增加的百分比（魔法補充）。\n" +
                    "例如：最大 10,000、設定 20% 時，會增加 2,000。"},

                // Global overflow toggle (PO + PSF)
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.FixMailOverflow)), "修正郵件溢出" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.FixMailOverflow)),
                    "當郵件太多時，設施會進行小幅度的「魔法清理」。\n " +
                    "多餘的郵件會視為已送達並被移除。\n " +
                    "這可以避免設施永遠維持滿載卡住。\n " +
                    "關閉此選項可維持純原版行為。" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PO_OverflowPercentage)), "郵局溢出門檻" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PO_OverflowPercentage)),
                    "當郵局的總郵件量達到此百分比時，模組會\n" +
                    "刪除部分郵件，讓存量回到這個水準。" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PSF_OverflowPercentage)), "分揀溢出門檻" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PSF_OverflowPercentage)),
                   "當分揀設施的總郵件量達到此百分比時，模組會\n" +
                   "刪除部分郵件，讓存量回到這個水準。" },

                // ---- Post Vans & Trucks ----
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ChangeCapacity)), "調整容量" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ChangeCapacity)),
                    "啟用後可修改郵車與卡車容量。關閉時，\n" +
                    "下方所有容量滑桿會隱藏，\n" +
                    "即使你更改過，仍會使用原版數值。" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PostVanMailLoadPercentage)), "郵政貨車載量" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PostVanMailLoadPercentage)),
                    "控制每輛郵政貨車可以載多少郵件。\n" +
                    "<100% = 原版載量>" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PostVanFleetSizePercentage)), "郵政貨車數量" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PostVanFleetSizePercentage)),
                    "控制每座郵政建築可以擁有與派出的郵政貨車數量。\n" +
                    "<100% = 原版數量>" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TruckCapacityPercentage)), "郵政卡車數量" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TruckCapacityPercentage)),
                    "控制每座分揀設施（或有郵政卡車的設施）\n " +
                    "可以擁有與派出的卡車數量。\n " +
                    "<100% = 原版數量>" },

                // ---- Sorting Facility ----
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PSF_SortingSpeedPercentage)), "分揀速度" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PSF_SortingSpeedPercentage)),
                    "套用在分揀設施基礎分揀速度上的倍率。\n " +
                    "<100% = 原版>" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PSF_StorageCapacityPercentage)), "分揀儲存容量" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PSF_StorageCapacityPercentage)),
                    "控制郵件儲存容量。\n " +
                    "<100% = 原版>" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PSF_GetUnsortedMail)), "修正未分揀郵件不足" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PSF_GetUnsortedMail)),
                    "啟用後，當未分揀郵件存量過低時，會「魔法」生成一些。\n " +
                    "讓分揀建築不用等車也能持續運作。\n" +
                    "暫時修正目前有貨櫃港口時，分揀設施郵件不足的問題。" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PSF_GettingThresholdPercentage)), "未分揀郵件門檻" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PSF_GettingThresholdPercentage)),
                    "當未分揀郵件低於此容量百分比時，\n" +
                    "會額外「抓」一些未分揀郵件。 \n" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PSF_GettingPercentage)), "未分揀郵件補充量" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PSF_GettingPercentage)),
                    "補充未分揀郵件時要增加的郵件量（魔法補充）。\n" +
                    "以最大儲存容量的百分比計算。" },

                // ---- RESET BUTTONS ----
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ResetToVanilla)), "恢復原版預設" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ResetToVanilla)),
                    "將所有設定恢復為遊戲原本的預設行為（原版）。" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ResetToRecommend)), "推薦設定" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ResetToRecommend)),
                    "**快速開始** - 一鍵套用所有推薦郵件設定。\n" +
                    "輕鬆模式：點一下就完成！" },

                // ---- Status tab ----
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.StatusFacilitySummary)), "" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.StatusFacilitySummary)),
                    "顯示在上一次遊戲更新中處理的郵局、郵政貨車、\n" +
                    "分揀設施與郵政卡車的概要（遊戲內約每 45 分鐘一次）。" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.StatusCityMailSummary)), "城市郵件" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.StatusCityMailSummary)),
                    "顯示最近全城的郵件流量。\n\n" +
                     "**Accumulated（累積）** = 市民產生的郵件量。\n" +
                     "**Processed（已處理）**   = 網路實際處理的郵件量。\n\n" +
                     "- 如果 Processed 常常高於 Accumulated，代表郵政網路容量充足。\n " +
                     "- 如果 Accumulated 長時間高於 Processed，代表郵件過多處理不完；\n " +
                     "請增加設施、車輛或調整設定。" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.StatusLastActivity)), "活動" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.StatusLastActivity)),
                    "顯示上一輪更新中進行的郵件補充與溢出清理次數。" },

                // ---- About tab: info ----
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ModNameDisplay)), "Mod" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ModNameDisplay)),
                    "此 Mod 的顯示名稱。" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ModVersionDisplay)), "版本" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ModVersionDisplay)),
                    "目前的 Mod 版本。" },

                // ---- About tab: links ----
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.OpenParadox)), "Paradox" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.OpenParadox)),
                    "開啟 **Magic Mail** 以及其他 Mod 的 Paradox 網頁。" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.OpenDiscord)), "Discord" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.OpenDiscord)),
                    "在瀏覽器中開啟 **Discord** 回饋聊天室。" },
            };
        }

        /// <summary>
        /// Called when the localization source is unloaded.</summary>
        public void Unload()
        {
        }
    }
}
