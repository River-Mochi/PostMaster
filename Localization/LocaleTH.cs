// Localization/LocaleTH.cs
// Thai locale th-TH

namespace MagicMail
{
    using System.Collections.Generic;
    using Colossal;

    /// <summary>
    /// Thai localization source for Magic Mail [MM].</summary>
    public sealed class LocaleTH : IDictionarySource
    {
        private readonly Setting m_Setting;

        /// <summary>
        /// Constructs the Thai locale generator.</summary>
        /// <param name="setting">Settings object used for locale IDs.</param>
        public LocaleTH(Setting setting)
        {
            m_Setting = setting;
        }

        /// <summary>
        /// Generates all Thai localization entries for this mod.</summary>
        public IEnumerable<KeyValuePair<string, string>> ReadEntries(
            IList<IDictionaryEntryError> errors,
            Dictionary<string, int> indexCounts)
        {
            return new Dictionary<string, string>
            {
                // Mod title
                { m_Setting.GetSettingsLocaleID(), "เมจิกเมล [MM]" },

                // Tabs
                { m_Setting.GetOptionTabLocaleID(Setting.kActionsTab), "การตั้งค่า" },
                { m_Setting.GetOptionTabLocaleID(Setting.kStatusTab),  "สถานะ" },
                { m_Setting.GetOptionTabLocaleID(Setting.kAboutTab),   "เกี่ยวกับ" },

                // Groups (Actions tab)
                { m_Setting.GetOptionGroupLocaleID(Setting.PostOfficeGroup),          "ที่ทำการไปรษณีย์" },
                { m_Setting.GetOptionGroupLocaleID(Setting.PostVanGroup),             "รถไปรษณีย์ & รถบรรทุก" },
                { m_Setting.GetOptionGroupLocaleID(Setting.PostSortingFacilityGroup), "ศูนย์คัดแยก" },
                { m_Setting.GetOptionGroupLocaleID(Setting.ResetGroup),               "รีเซ็ต" },

                // Groups (Status tab)
                { m_Setting.GetOptionGroupLocaleID(Setting.StatusSummaryGroup), "สแกนเมือง" },
                { m_Setting.GetOptionGroupLocaleID(Setting.StatusActivityGroup), "การอัปเดตล่าสุด" },

                // Groups (About tab)
                { m_Setting.GetOptionGroupLocaleID(Setting.kAboutInfoGroup),  "ข้อมูล" },
                { m_Setting.GetOptionGroupLocaleID(Setting.kAboutLinksGroup), "ลิงก์" },

                // ---- Post Office ----
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PO_GetLocalMail)), "แก้ปัญหาไปรษณีย์ท้องถิ่นเหลือน้อย" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PO_GetLocalMail)),
                    "เมื่อเปิดใช้ ถ้าพื้นที่เก็บจดหมายเหลือน้อย ระบบจะสร้างจดหมายเพิ่มให้อัตโนมัติ\n " +
                    "จะไม่เรียกรถไปรษณีย์เพิ่ม เป็นเหมือนเวทมนตร์…แต่เกิดขึ้นจริง :)" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PO_GettingThresholdPercentage)), "เกณฑ์ไปรษณีย์ท้องถิ่น" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PO_GettingThresholdPercentage)),
                    "ถ้าปริมาณไปรษณีย์ท้องถิ่นลดลงต่ำกว่าค่าเปอร์เซ็นต์ที่คุณตั้งไว้\n " +
                    "ที่ทำการไปรษณีย์จะดึงไปรษณีย์ท้องถิ่นเพิ่มให้อัตโนมัติ\n" +
                    "คิดจากเปอร์เซ็นต์ของความจุสูงสุดของพื้นที่เก็บ" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PO_GettingPercentage)), "จำนวนไปรษณีย์ท้องถิ่นที่ดึงเพิ่ม" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PO_GettingPercentage)),
                    "เปอร์เซ็นต์ที่ใช้เพิ่มไปรษณีย์ท้องถิ่นเมื่อดึงเข้ามา (ชาร์จเวทมนตร์เพิ่ม).\n" +
                    "ตัวอย่าง: ถ้าค่าสูงสุดแบบวานิลลา = 10,000 และตั้งค่าเป็น 20% จะเพิ่ม 2,000"},

                // Global overflow toggle (PO + PSF)
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.FixMailOverflow)), "แก้ปัญหาไปรษณีย์ล้นคลัง" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.FixMailOverflow)),
                    "เมื่อมีไปรษณีย์มากเกินไป สิ่งอำนวยความสะดวกจะทำการ \"เคลียร์\" แบบเวทมนตร์เล็กน้อย\n " +
                    "ไปรษณีย์ส่วนเกินจะถือว่า \"ส่งแล้ว\" และถูกลบออกจากสต็อก\n " +
                    "ช่วยป้องกันไม่ให้ที่ทำการไปรษณีย์/ศูนย์คัดแยกเต็มตลอดจนระบบค้าง\n " +
                    "ถ้าอยากได้พฤติกรรมเดิมแบบวานิลลา ให้ปิดตัวเลือกนี้" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PO_OverflowPercentage)), "เกณฑ์ไปรษณีย์ล้น (ที่ทำการไปรษณีย์)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PO_OverflowPercentage)),
                    "เมื่อปริมาณไปรษณีย์รวมในที่ทำการไปรษณีย์ถึงเปอร์เซ็นต์นี้\n" +
                    "ม็อดจะลบจดหมายส่วนเกินให้ เหลือไว้ประมาณระดับนี้" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PSF_OverflowPercentage)), "เกณฑ์ไปรษณีย์ล้น (ศูนย์คัดแยก)" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PSF_OverflowPercentage)),
                   "เมื่อปริมาณไปรษณีย์รวมในศูนย์คัดแยกถึงเปอร์เซ็นต์นี้\n" +
                   "ม็อดจะลบจดหมายส่วนเกินให้ เหลือไว้ประมาณระดับนี้" },

                // ---- Post Vans & Trucks ----
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ChangeCapacity)), "ปรับความจุ" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ChangeCapacity)),
                    "เปิดเพื่อปรับความจุของรถตู้และรถบรรทุกไปรษณีย์\n" +
                    "ถ้าปิด สไลเดอร์ทั้งหมดด้านล่างจะถูกซ่อน\n" +
                    "และใช้ค่ามาตรฐานของเกม (วานิลลา) แม้คุณจะเคยเลื่อนค่าสไลเดอร์ไว้ก็ตาม" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PostVanMailLoadPercentage)), "ปริมาณบรรทุกของรถตู้ไปรษณีย์" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PostVanMailLoadPercentage)),
                    "ควบคุมปริมาณไปรษณีย์ที่รถตู้หนึ่งคันสามารถบรรทุกได้\n" +
                    "<100% = ปริมาณแบบวานิลลา>" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PostVanFleetSizePercentage)), "จำนวนรถตู้ไปรษณีย์" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PostVanFleetSizePercentage)),
                    "ควบคุมจำนวนรถตู้ไปรษณีย์ที่แต่ละอาคารสามารถมีและส่งออกได้\n" +
                    "<100% = จำนวนรถตามค่ามาตรฐาน>" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TruckCapacityPercentage)), "จำนวนรถบรรทุกไปรษณีย์" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TruckCapacityPercentage)),
                    "ควบคุมจำนวนรถบรรทุกไปรษณีย์ของแต่ละศูนย์คัดแยก (และอาคารอื่นที่ใช้รถบรรทุกไปรษณีย์)\n " +
                    "ที่สามารถมีและส่งออกได้\n " +
                    "<100% = จำนวนรถตามค่ามาตรฐาน>" },

                // ---- Sorting Facility ----
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PSF_SortingSpeedPercentage)), "ความเร็วในการคัดแยก" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PSF_SortingSpeedPercentage)),
                    "ตัวคูณความเร็วสำหรับศูนย์ **คัดแยก** ไปรษณีย์ ใช้กับความเร็วพื้นฐานของอาคาร\n " +
                    "<100% = ความเร็วแบบวานิลลา>" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PSF_StorageCapacityPercentage)), "ความจุคลังของศูนย์คัดแยก" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PSF_StorageCapacityPercentage)),
                    "ควบคุมความจุการเก็บ **จดหมาย** ของศูนย์คัดแยก\n " +
                    "<100% = ความจุแบบวานิลลา>" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PSF_GetUnsortedMail)), "แก้ปัญหาไปรษณีย์ยังไม่คัดแยกเหลือน้อย" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PSF_GetUnsortedMail)),
                    "เมื่อเปิดใช้ ถ้าไปรษณีย์ที่ยังไม่คัดแยกในคลังเหลือน้อย จะมีจดหมายเพิ่มขึ้นมาเล็กน้อยโดยอัตโนมัติ\n " +
                    "ทำให้ศูนย์คัดแยกยังทำงานต่อได้โดยไม่ต้องรอให้มีการส่งของเข้ามา\n" +
                    "ใช้เป็นการแก้บั๊กชั่วคราว ที่ศูนย์คัดแยกไม่ได้รับเมลเพียงพอเมื่อมีท่าเรือสินค้าบางแบบในเมือง" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PSF_GettingThresholdPercentage)), "เกณฑ์ไปรษณีย์ยังไม่คัดแยก" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PSF_GettingThresholdPercentage)),
                    "ถ้าจำนวนไปรษณีย์ที่ยังไม่คัดแยกลดลงต่ำกว่าค่าเปอร์เซ็นต์นี้\n" +
                    "ระบบจะดึงไปรษณีย์ยังไม่คัดแยกเพิ่มเข้ามาแบบเวทมนตร์\n" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PSF_GettingPercentage)), "จำนวนไปรษณีย์ยังไม่คัดแยกที่ดึงเพิ่ม" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PSF_GettingPercentage)),
                    "ปริมาณไปรษณีย์เพิ่มที่ใช้เมื่อต้องดึงไปรษณีย์ยังไม่คัดแยกเข้ามา (ชาร์จเวทมนตร์เพิ่ม)\n" +
                    "คิดจากเปอร์เซ็นต์ของความจุสูงสุดของคลัง" },

                // ---- RESET BUTTONS ----
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ResetToVanilla)), "ค่าเริ่มต้นของเกม" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ResetToVanilla)),
                    "รีเซ็ตการตั้งค่าทั้งหมดกลับไปเป็นพฤติกรรมมาตรฐานของเกม (วานิลลา)." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ResetToRecommend)), "แนะนำ" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ResetToRecommend)),
                    "**เริ่มเร็ว** – ใช้ค่าการตั้งค่าไปรษณีย์ที่แนะนำทั้งหมดในครั้งเดียว\n" +
                    "โหมดสบาย ๆ: คลิกเดียวแล้วจบ!" },

                // ---- Status tab ----
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.StatusFacilitySummary)), "" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.StatusFacilitySummary)),
                    "สรุปจำนวนที่ทำการไปรษณีย์ รถตู้ไปรษณีย์ ศูนย์คัดแยก และรถบรรทุกไปรษณีย์\n" +
                    "ที่ถูกประมวลผลในการอัปเดตเกมครั้งล่าสุด (~ทุก ๆ 45 นาทีในเกม)." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.StatusCityMailSummary)), "ไปรษณีย์ทั้งเมือง" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.StatusCityMailSummary)),
                    "แสดงการไหลของไปรษณีย์ในระดับเมืองช่วงหลัง ๆ\n\n" +
                     "**Accumulated** = ปริมาณจดหมายที่ประชาชนสร้างขึ้นทั้งหมด\n" +
                     "**Processed**   = ปริมาณจดหมายที่เครือข่ายไปรษณีย์จัดการได้จริง\n\n" +
                     "- ถ้า Processed มักจะสูงกว่า Accumulated แสดงว่าระบบไปรษณีย์ของคุณรองรับได้สบาย\n " +
                     "- ถ้า Accumulated สูงกว่า Processed ต่อเนื่อง แปลว่าเมืองสร้างจดหมายเกินกว่าระบบจะรองรับได้\n " +
                     "ควรเพิ่มสิ่งอำนวยความสะดวก รถ หรือปรับแต่งค่าการตั้งค่าเพิ่มเติม" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.StatusLastActivity)), "กิจกรรมล่าสุด" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.StatusLastActivity)),
                    "จำนวนครั้งของการดึงไปรษณีย์เพิ่ม และการเคลียร์ไปรษณีย์ล้น\nที่เกิดขึ้นในการอัปเดตครั้งล่าสุด." },

                // ---- About tab: info ----
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ModNameDisplay)), "ม็อด" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ModNameDisplay)),
                    "ชื่อที่แสดงของม็อดนี้." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ModVersionDisplay)), "เวอร์ชัน" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ModVersionDisplay)),
                    "เวอร์ชันปัจจุบันของม็อด." },

                // ---- About tab: links ----
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.OpenParadox)), "Paradox" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.OpenParadox)),
                    "เปิดหน้าเว็บ **Paradox** ของ **Magic Mail** และม็อดอื่น ๆ." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.OpenDiscord)), "Discord" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.OpenDiscord)),
                    "เปิดห้องพูดคุยฟีดแบ็กใน **Discord** ผ่านเบราว์เซอร์." },
            };
        }

        /// <summary>
        /// Called when the localization source is unloaded.</summary>
        public void Unload()
        {
        }
    }
}
