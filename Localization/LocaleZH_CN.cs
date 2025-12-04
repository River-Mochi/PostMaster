// Localization/LocaleZH_CN.cs
// Simplified Chinese locale zh-HANS

namespace MagicMail
{
    using System.Collections.Generic;
    using Colossal;

    /// <summary>
    /// Simplified Chinese localization source for Magic Mail [MM].</summary>
    public sealed class LocaleZH_CN : IDictionarySource
    {
        private readonly Setting m_Setting;

        /// <summary>
        /// Constructs the Simplified Chinese locale generator.</summary>
        /// <param name="setting">Settings object used for locale IDs.</param>
        public LocaleZH_CN(Setting setting)
        {
            m_Setting = setting;
        }

        /// <summary>
        /// Generates all Simplified Chinese localization entries for this mod.</summary>
        public IEnumerable<KeyValuePair<string, string>> ReadEntries(
            IList<IDictionaryEntryError> errors,
            Dictionary<string, int> indexCounts)
        {
            return new Dictionary<string, string>
            {
                // Mod title
                { m_Setting.GetSettingsLocaleID(), "魔法邮政 [MM]" },

                // Tabs
                { m_Setting.GetOptionTabLocaleID(Setting.kActionsTab), "操作" },
                { m_Setting.GetOptionTabLocaleID(Setting.kStatusTab),  "状态" },
                { m_Setting.GetOptionTabLocaleID(Setting.kAboutTab),   "关于" },

                // Groups (Actions tab)
                { m_Setting.GetOptionGroupLocaleID(Setting.PostOfficeGroup),          "邮局" },
                { m_Setting.GetOptionGroupLocaleID(Setting.PostVanGroup),             "邮政货车与卡车" },
                { m_Setting.GetOptionGroupLocaleID(Setting.PostSortingFacilityGroup), "分拣中心" },
                { m_Setting.GetOptionGroupLocaleID(Setting.ResetGroup),               "重置" },

                // Groups (Status tab)
                { m_Setting.GetOptionGroupLocaleID(Setting.StatusSummaryGroup),  "城市扫描" },
                { m_Setting.GetOptionGroupLocaleID(Setting.StatusActivityGroup), "上次更新" },

                // Groups (About tab)
                { m_Setting.GetOptionGroupLocaleID(Setting.kAboutInfoGroup),  "信息" },
                { m_Setting.GetOptionGroupLocaleID(Setting.kAboutLinksGroup), "链接" },

              // ---- Post Office ----
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PO_GetLocalMail)), "修复本地邮件过低" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PO_GetLocalMail)),
                    "启用后，如果本地邮件过低，会自动生成少量邮件。\n " +
                    "不会生成额外的邮车；就像魔法一样，但是真的 :)" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PO_GettingThresholdPercentage)), "本地邮件阈值" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PO_GettingThresholdPercentage)),
                    "当本地邮件低于你设定的百分比时，\n " +
                    "邮局会自动补充更多本地邮件。\n" +
                    "此阈值是建筑最大容量的百分比。\n" +
                    "例如：<最大容量 = 100,000> 且 <阈值 = 5%>，\n" +
                    "当本地邮件 < <5,000> 时，就会触发补邮件。" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PO_GettingPercentage)), "本地邮件补充量" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PO_GettingPercentage)),
                    "触发补货时要增加的本地邮件百分比（魔法“加满”）。\n" +
                    "例如：若 vanilla 最大值 = <100,000> 且此项 = <10%>，\n" +
                    "那么需要时会一次性补充 <10,000> 本地邮件。"},

                // Global overflow toggle (PO + PSF)
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.FixMailOverflow)), "修复邮件溢出" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.FixMailOverflow)),
                    "当邮件过多时，设施会进行一次小型“魔法清理”。\n " +
                    "多余的存储邮件会被视为已投递并删除。\n " +
                    "这样可以避免设施一直被塞满、完全卡死。\n " +
                    "关闭此选项可保持纯原版（vanilla）行为。" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PO_OverflowPercentage)), "邮局溢出阈值" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PO_OverflowPercentage)),
                    "当某个邮局的总邮件达到这个百分比时，模组会删除一部分存储邮件，\n" +
                    "把总量压回到该百分比附近。" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PSF_OverflowPercentage)), "分拣中心溢出阈值" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PSF_OverflowPercentage)),
                   "当分拣设施的总邮件达到这个百分比时，模组会删除一部分存储邮件，\n" +
                   "把总量压回到该百分比附近。" },

                // ---- Post Vans & Trucks ----
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ChangeCapacity)), "修改容量" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ChangeCapacity)),
                    "启用后才会修改货车/卡车的容量。\n" +
                    "当此项关闭时，下方所有容量滑条都会被隐藏，\n" +
                    "即使你之前改过数值，也会使用原版（游戏）的默认值。" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PostVanMailLoadPercentage)), "邮政货车载量" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PostVanMailLoadPercentage)),
                    "控制每辆邮政货车能装多少邮件。\n" +
                    "<100% = 原版载量。>" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PostVanFleetSizePercentage)), "邮政货车车队规模" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PostVanFleetSizePercentage)),
                    "控制每座邮政建筑能拥有并派出的邮政货车数量。\n" +
                    "<100% = 原版车队规模。>" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TruckCapacityPercentage)), "邮政卡车车队规模" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TruckCapacityPercentage)),
                    "控制每个分拣设施（以及任何带邮政卡车的建筑）\n " +
                    "能拥有并派出的邮政卡车数量。\n " +
                    "<100% = 原版车队规模。>" },

                // ---- Sorting Facility ----
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PSF_SortingSpeedPercentage)), "分拣速度" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PSF_SortingSpeedPercentage)),
                    "分拣设施的速度倍率，作用于建筑的基础分拣速率。\n " +
                    "<100% = 原版>" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PSF_StorageCapacityPercentage)), "分拣存储容量" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PSF_StorageCapacityPercentage)),
                    "控制分拣设施的**邮件存储容量**。\n " +
                    "<100% = 原版>" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PSF_GetUnsortedMail)), "修复未分拣邮件过低" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PSF_GetUnsortedMail)),
                    "启用后，如果未分拣邮件太少，会“魔法”补一些未分拣邮件。\n " +
                    "这样分拣建筑无需等车送货也能持续工作。\n" +
                    "这是当前一个 bug 的临时修复：如果城市有货运港口，\n" +
                    "分拣设施经常拿不到足够的邮件。" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PSF_GettingThresholdPercentage)), "未分拣邮件阈值" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PSF_GettingThresholdPercentage)),
                    "如果未分拣邮件低于总存储容量的这个低百分比，\n" +
                    "就会“魔法”拉入一部分额外未分拣邮件。\n" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PSF_GettingPercentage)), "未分拣邮件补充量" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PSF_GettingPercentage)),
                    "触发补货时要增加的未分拣邮件量（魔法“加满”）。\n" +
                    "数值是最大存储容量的百分比。\n" +
                    "例如：若原版最大 = 250,000 且此项 = 10%，\n" +
                    "那么一次会补充 25,000 未分拣邮件。"
                },

                // ---- RESET BUTTONS ----
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ResetToVanilla)), "游戏默认" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ResetToVanilla)),
                    "把所有设置恢复为游戏最初的原版行为（vanilla）。" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ResetToRecommend)), "推荐预设" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ResetToRecommend)),
                    "**快速上手** —— 一键应用推荐的邮政设置。\n" +
                    "休闲模式：点一次就搞定！" },

                // ---- Status tab ----
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.StatusFacilitySummary)), "" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.StatusFacilitySummary)),
                    "展示最近一次游戏更新中处理过的邮局、邮政货车、分拣设施\n" +
                    "以及邮政卡车的汇总情况（大约每 45 分钟游戏时间更新一次）。" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.StatusCityMailSummary)), "每月邮件" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.StatusCityMailSummary)),
                    "显示最近一段时间全城邮件的流量情况。\n\n" +
                     "**Accumulated（累计）** = 市民产生了多少邮件。\n" +
                     "**Processed（已处理）**   = 邮政网络实际处理了多少邮件。\n\n" +
                     "- 如果“已处理”经常高于“累计”，说明你的邮政网络够用。\n " +
                     "- 如果“累计”长期高于“已处理”，说明城市产出的邮件太多，\n " +
                     "  当前网络吃不下；可以多建设施、加车或调整设置。"
                },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.StatusLastActivity)), "活动记录" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.StatusLastActivity)),
                    "统计上一次更新中执行的补货次数和溢出清理次数。" },

                // ---- About tab: info ----
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ModNameDisplay)), "模组" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ModNameDisplay)),
                    "此模组在游戏里显示的名称。" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ModVersionDisplay)), "版本" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ModVersionDisplay)),
                    "当前模组版本号。" },

                // ---- About tab: links ----
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.OpenParadox)), "Paradox" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.OpenParadox)),
                    "在浏览器中打开 **Magic Mail** 以及作者其它模组的 Paradox 页面。" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.OpenDiscord)), "Discord" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.OpenDiscord)),
                    "在浏览器中打开 **Discord** 反馈与交流频道。" },
            };
        }

        /// <summary>
        /// Called when the localization source is unloaded.</summary>
        public void Unload()
        {
        }
    }
}
