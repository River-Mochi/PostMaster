// Localization/LocaleJA.cs
// Japanese locale ja-JP

namespace MagicMail
{
    using System.Collections.Generic;
    using Colossal;

    /// <summary>
    /// Japanese localization source for Magic Mail [MM].</summary>
    public sealed class LocaleJA : IDictionarySource
    {
        private readonly Setting m_Setting;

        /// <summary>
        /// Constructs the Japanese locale generator.</summary>
        /// <param name="setting">Settings object used for locale IDs.</param>
        public LocaleJA(Setting setting)
        {
            m_Setting = setting;
        }

        /// <summary>
        /// Generates all Japanese localization entries for this mod.</summary>
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
                { m_Setting.GetOptionTabLocaleID(Setting.kStatusTab),  "状況" },
                { m_Setting.GetOptionTabLocaleID(Setting.kAboutTab),   "情報" },

                // Groups (Actions tab)
                { m_Setting.GetOptionGroupLocaleID(Setting.PostOfficeGroup),          "郵便局" },
                { m_Setting.GetOptionGroupLocaleID(Setting.PostVanGroup),             "郵便バン・トラック" },
                { m_Setting.GetOptionGroupLocaleID(Setting.PostSortingFacilityGroup), "仕分け施設" },
                { m_Setting.GetOptionGroupLocaleID(Setting.ResetGroup),               "リセット" },

                // Groups (Status tab)
                { m_Setting.GetOptionGroupLocaleID(Setting.StatusSummaryGroup), "都市スキャン" },
                { m_Setting.GetOptionGroupLocaleID(Setting.StatusActivityGroup), "直近の動き" },

                // Groups (About tab)
                { m_Setting.GetOptionGroupLocaleID(Setting.kAboutInfoGroup),  "概要" },
                { m_Setting.GetOptionGroupLocaleID(Setting.kAboutLinksGroup), "リンク" },

                // ---- Post Office ----
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PO_GetLocalMail)), "ローカル郵便の不足を修正" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PO_GetLocalMail)),
                    "オンにすると、郵便在庫が少ない時に追加の郵便が現れます。\n " +
                    "追加のバンは出ません。ちょっとした“マジック”です。" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PO_GettingThresholdPercentage)), "ローカル郵便のしきい値" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PO_GettingThresholdPercentage)),
                    "ローカル郵便がこの割合を下回ると、\n " +
                    "郵便局が追加の郵便を引き寄せます。\n" +
                    "最大容量に対する割合です。" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PO_GettingPercentage)), "ローカル郵便の追加量" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PO_GettingPercentage)),
                    "ローカル郵便を補充するときの追加割合（マジック補充）。\n" +
                    "例：最大10,000で20%なら 2,000 を追加。" },

                // Global overflow toggle (PO + PSF)
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.FixMailOverflow)), "郵便のあふれ修正" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.FixMailOverflow)),
                    "郵便が多すぎる場合、施設が小さなマジック清掃を行います。\n " +
                    "余分な郵便は処理済みとして削除されます。\n " +
                    "施設が満杯で止まるのを防ぎます。\n " +
                    "オフにするとバニラ動作です。" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PO_OverflowPercentage)), "郵便局のあふれ閾値" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PO_OverflowPercentage)),
                    "郵便局の総郵便量がこの割合に達したら、\n" +
                    "このレベルまで削減されます。" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PSF_OverflowPercentage)), "仕分け施設のあふれ閾値" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PSF_OverflowPercentage)),
                    "仕分け施設の総郵便量がこの割合に達したら、\n" +
                    "このレベルまで削減されます。" },

                // ---- Post Vans & Trucks ----
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ChangeCapacity)), "容量を変更" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ChangeCapacity)),
                    "バンとトラックの容量を変更します。オフにすると\n" +
                    "以下のスライダーは非表示になり、ゲームの値が使用されます。" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PostVanMailLoadPercentage)), "郵便バンの積載量" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PostVanMailLoadPercentage)),
                    "各バンが運べる郵便量を調整します。\n" +
                    "<100% = バニラと同じ>" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PostVanFleetSizePercentage)), "郵便バンの台数" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PostVanFleetSizePercentage)),
                    "建物が保有・出動できる郵便バンの数を調整します。\n" +
                    "<100% = バニラ台数>" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TruckCapacityPercentage)), "郵便トラックの台数" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TruckCapacityPercentage)),
                    "仕分け施設が持つ郵便トラック台数を調整します。\n " +
                    "<100% = バニラ台数>" },

                // ---- Sorting Facility ----
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PSF_SortingSpeedPercentage)), "仕分け速度" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PSF_SortingSpeedPercentage)),
                    "仕分け施設の基本仕分け速度の倍率。\n " +
                    "<100% = バニラ>" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PSF_StorageCapacityPercentage)), "仕分け倉庫容量" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PSF_StorageCapacityPercentage)),
                    "郵便の保管容量を調整します。\n " +
                    "<100% = バニラ>" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PSF_GetUnsortedMail)), "未仕分け郵便の不足を修正" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PSF_GetUnsortedMail)),
                    "在庫が少ないとき、未仕分け郵便が少し現れます。\n " +
                    "これにより施設が止まらず動き続けます。\n" +
                    "現在のバグ（港があると郵便が届きにくい）への暫定対策です。" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PSF_GettingThresholdPercentage)), "未仕分け郵便のしきい値" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PSF_GettingThresholdPercentage)),
                    "未仕分け郵便がこの割合を下回ると、追加で取得します。 \n" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PSF_GettingPercentage)), "未仕分け郵便の追加量" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PSF_GettingPercentage)),
                    "未仕分け郵便を補充するときの追加割合。\n" +
                    "最大容量に対する割合です。" },

                // ---- RESET BUTTONS ----
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ResetToVanilla)), "バニラに戻す" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ResetToVanilla)),
                    "すべての設定をゲームの初期値（バニラ）に戻します。" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ResetToRecommend)), "おすすめ設定" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ResetToRecommend)),
                    "ワンクリックでおすすめ設定を適用します。\n" +
                    "かんたんモード！" },

                // ---- Status tab ----
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.StatusFacilitySummary)), "" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.StatusFacilitySummary)),
                    "直近の更新で処理された郵便局、郵便バン、仕分け施設、\n" +
                    "郵便トラックの概要です。（ゲーム内 約45分ごと）" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.StatusCityMailSummary)), "都市の郵便" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.StatusCityMailSummary)),
                    "最近の都市全体の郵便量を表示します。\n\n" +
                     "**Accumulated（蓄積）** = 市民が生成した郵便量\n" +
                     "**Processed（処理）**   = ネットワークが実際に処理した郵便量\n\n" +
                     "- Processed が Accumulated より多ければ、郵便網は十分強いです。\n " +
                     "- Accumulated が常に高い場合は不足しており、施設やバンの増強が必要です。" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.StatusLastActivity)), "アクティビティ" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.StatusLastActivity)),
                    "直近の更新で行われた郵便取得数とオーバーフロー処理数。" },

                // ---- About tab: info ----
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ModNameDisplay)), "Mod" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ModNameDisplay)),
                    "この Mod の名前。" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ModVersionDisplay)), "バージョン" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ModVersionDisplay)),
                    "現在の Mod バージョン。" },

                // ---- About tab: links ----
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.OpenParadox)), "Paradox" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.OpenParadox)),
                    "Magic Mail などの Paradox ページを開きます。" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.OpenDiscord)), "Discord" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.OpenDiscord)),
                    "Discord のフィードバックチャットをブラウザで開きます。" },
            };
        }

        /// <summary>
        /// Called when the localization source is unloaded.</summary>
        public void Unload()
        {
        }
    }
}
