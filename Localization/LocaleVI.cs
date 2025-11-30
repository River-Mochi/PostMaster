// Localization/LocaleVI.cs
// Vietnamese locale vi-VN

namespace MagicMail
{
    using System.Collections.Generic;
    using Colossal;

    /// <summary>
    /// Vietnamese localization source for Magic Mail [MM].</summary>
    public sealed class LocaleVI : IDictionarySource
    {
        private readonly Setting m_Setting;

        /// <summary>
        /// Constructs the Vietnamese locale generator.</summary>
        /// <param name="setting">Settings object used for locale IDs.</param>
        public LocaleVI(Setting setting)
        {
            m_Setting = setting;
        }

        /// <summary>
        /// Generates all Vietnamese localization entries for this mod.</summary>
        public IEnumerable<KeyValuePair<string, string>> ReadEntries(
            IList<IDictionaryEntryError> errors,
            Dictionary<string, int> indexCounts)
        {
            return new Dictionary<string, string>
            {
                // Mod title
                { m_Setting.GetSettingsLocaleID(), "Magic Mail [MM]" },

                // Tabs
                { m_Setting.GetOptionTabLocaleID(Setting.kActionsTab), "Hành động" },
                { m_Setting.GetOptionTabLocaleID(Setting.kStatusTab),  "Trạng thái" },
                { m_Setting.GetOptionTabLocaleID(Setting.kAboutTab),   "Giới thiệu" },

                // Groups (Actions tab)
                { m_Setting.GetOptionGroupLocaleID(Setting.PostOfficeGroup),          "Bưu điện" },
                { m_Setting.GetOptionGroupLocaleID(Setting.PostVanGroup),             "Xe bưu phẩm & xe tải" },
                { m_Setting.GetOptionGroupLocaleID(Setting.PostSortingFacilityGroup), "Trung tâm phân loại" },
                { m_Setting.GetOptionGroupLocaleID(Setting.ResetGroup),               "Đặt lại" },

                // Groups (Status tab)
                { m_Setting.GetOptionGroupLocaleID(Setting.StatusSummaryGroup), "Quét thành phố" },
                { m_Setting.GetOptionGroupLocaleID(Setting.StatusActivityGroup), "Hoạt động gần đây" },

                // Groups (About tab)
                { m_Setting.GetOptionGroupLocaleID(Setting.kAboutInfoGroup),  "Thông tin" },
                { m_Setting.GetOptionGroupLocaleID(Setting.kAboutLinksGroup), "Liên kết" },

                // ---- Post Office ----
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PO_GetLocalMail)), "Sửa thư nội bộ thấp" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PO_GetLocalMail)),
                    "Khi bật và kho thư quá thấp, một ít thư bổ sung sẽ xuất hiện.\n " +
                    "Không sinh thêm xe; giống như phép thuật... nhưng thật :)" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PO_GettingThresholdPercentage)), "Ngưỡng thư nội bộ" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PO_GettingThresholdPercentage)),
                    "Nếu thư nội bộ xuống dưới tỷ lệ phần trăm bạn chọn,\n " +
                    "bưu điện sẽ kéo thêm thư nội bộ vào.\n" +
                    "Đây là phần trăm so với sức chứa tối đa." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PO_GettingPercentage)), "Lượng thư nội bộ thêm" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PO_GettingPercentage)),
                    "Tỷ lệ phần trăm được thêm khi lấy thư nội bộ (bù ma thuật).\n" +
                    "Ví dụ: tối đa 10.000, đặt 20% thì cộng thêm 2.000."},

                // Global overflow toggle (PO + PSF)
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.FixMailOverflow)), "Sửa tràn thư" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.FixMailOverflow)),
                    "Khi lượng thư quá lớn, các cơ sở sẽ dọn dẹp nhẹ bằng \"ma thuật\".\n " +
                    "Thư dư được coi là đã phát và bị xóa.\n " +
                    "Giúp cơ sở không bị kẹt mãi trong trạng thái đầy.\n " +
                    "Tắt để giữ đúng hành vi vanilla." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PO_OverflowPercentage)), "Ngưỡng tràn của bưu điện" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PO_OverflowPercentage)),
                    "Khi tổng thư ở bưu điện đạt tỷ lệ này,\n" +
                    "mod xóa bớt thư để đưa mức lưu trữ về lại mốc đó." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PSF_OverflowPercentage)), "Ngưỡng tràn của trung tâm phân loại" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PSF_OverflowPercentage)),
                   "Khi tổng thư ở trung tâm phân loại đạt tỷ lệ này,\n" +
                   "mod xóa bớt thư để đưa mức lưu trữ về lại mốc đó." },

                // ---- Post Vans & Trucks ----
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ChangeCapacity)), "Thay đổi sức chứa" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ChangeCapacity)),
                    "Bật để chỉnh sức chứa của xe và xe tải. Khi tắt,\n" +
                    "mọi thanh trượt bên dưới sẽ ẩn\n" +
                    "và trò chơi dùng giá trị vanilla, dù bạn đã chỉnh thanh trượt." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PostVanMailLoadPercentage)), "Tải thư trên xe bưu phẩm" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PostVanMailLoadPercentage)),
                    "Điều khiển lượng thư mỗi xe bưu phẩm có thể chở.\n" +
                    "<100% = giống vanilla>" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PostVanFleetSizePercentage)), "Số lượng xe bưu phẩm" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PostVanFleetSizePercentage)),
                    "Điều khiển số lượng xe bưu phẩm mỗi tòa nhà bưu điện có thể sở hữu và xuất phát.\n" +
                    "<100% = giống vanilla>" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TruckCapacityPercentage)), "Số lượng xe tải thư" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TruckCapacityPercentage)),
                    "Điều khiển số xe tải thư mỗi trung tâm phân loại (và cơ sở khác có xe tải thư)\n " +
                    "có thể sở hữu và xuất phát.\n " +
                    "<100% = giống vanilla>" },

                // ---- Sorting Facility ----
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PSF_SortingSpeedPercentage)), "Tốc độ phân loại" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PSF_SortingSpeedPercentage)),
                    "Hệ số nhân cho tốc độ phân loại cơ bản của trung tâm phân loại.\n " +
                    "<100% = vanilla>" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PSF_StorageCapacityPercentage)), "Sức chứa kho phân loại" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PSF_StorageCapacityPercentage)),
                    "Điều khiển sức chứa kho thư.\n " +
                    "<100% = vanilla>" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PSF_GetUnsortedMail)), "Sửa thư chưa phân loại thấp" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PSF_GetUnsortedMail)),
                    "Khi bật, nếu thư chưa phân loại trong kho quá thấp,\n " +
                    "sẽ xuất hiện thêm một ít một cách \"ma thuật\".\n" +
                    "Giữ cho trung tâm phân loại tiếp tục hoạt động không cần chờ xe giao.\n" +
                    "Giải pháp tạm cho lỗi hiện tại khi có cảng hàng hóa làm thư khó đến." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PSF_GettingThresholdPercentage)), "Ngưỡng thư chưa phân loại" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PSF_GettingThresholdPercentage)),
                    "Nếu thư chưa phân loại giảm dưới tỷ lệ phần trăm sức chứa này,\n" +
                    "mod sẽ kéo thêm một ít thư chưa phân loại. \n" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PSF_GettingPercentage)), "Lượng thư chưa phân loại thêm" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PSF_GettingPercentage)),
                    "Lượng thư bổ sung khi lấy thư chưa phân loại (bù ma thuật).\n" +
                    "Tính theo phần trăm sức chứa tối đa." },

                // ---- RESET BUTTONS ----
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ResetToVanilla)), "Mặc định trò chơi" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ResetToVanilla)),
                    "Khôi phục tất cả cài đặt về hành vi mặc định gốc của trò chơi (vanilla)." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ResetToRecommend)), "Khuyến nghị" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ResetToRecommend)),
                    "**Bắt đầu nhanh** – áp dụng mọi thiết lập bưu chính được khuyên dùng.\n" +
                    "Chế độ dễ: 1 lần nhấn là xong!" },

                // ---- Status tab ----
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.StatusFacilitySummary)), "" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.StatusFacilitySummary)),
                    "Tóm tắt bưu điện, xe bưu phẩm, trung tâm phân loại và xe tải thư\n" +
                    "được xử lý ở lần cập nhật trò chơi gần nhất (~mỗi 45 phút trong game)." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.StatusCityMailSummary)), "Thư của thành phố" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.StatusCityMailSummary)),
                    "Hiển thị dòng chảy thư gần đây trên toàn thành phố.\n\n" +
                     "**Accumulated (tích lũy)** = lượng thư do cư dân tạo ra.\n" +
                     "**Processed (xử lý)**   = lượng thư mạng lưới thực sự đã xử lý.\n\n" +
                     "- Nếu Processed thường cao hơn Accumulated, mạng lưới bưu chính đủ mạnh.\n " +
                     "- Nếu Accumulated lâu dài cao hơn Processed, thành phố tạo ra nhiều thư hơn\n " +
                     "khả năng xử lý – hãy thêm cơ sở, xe hoặc chỉnh lại thiết lập." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.StatusLastActivity)), "Hoạt động" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.StatusLastActivity)),
                    "Số lần kéo thư và dọn tràn đã thực hiện trong lần cập nhật gần nhất." },

                // ---- About tab: info ----
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ModNameDisplay)), "Mod" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ModNameDisplay)),
                    "Tên hiển thị của mod này." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ModVersionDisplay)), "Phiên bản" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ModVersionDisplay)),
                    "Phiên bản hiện tại của mod." },

                // ---- About tab: links ----
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.OpenParadox)), "Paradox" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.OpenParadox)),
                    "Mở trang **Paradox** của **Magic Mail** và các mod khác." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.OpenDiscord)), "Discord" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.OpenDiscord)),
                    "Mở kênh phản hồi **Discord** trong trình duyệt." },
            };
        }

        /// <summary>
        /// Called when the localization source is unloaded.</summary>
        public void Unload()
        {
        }
    }
}
