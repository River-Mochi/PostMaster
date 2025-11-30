// Localization/LocalePL.cs
// Polish locale pl-PL

namespace MagicMail
{
    using System.Collections.Generic;
    using Colossal;

    /// <summary>
    /// Polish localization source for Magic Mail [MM].</summary>
    public sealed class LocalePL : IDictionarySource
    {
        private readonly Setting m_Setting;

        /// <summary>
        /// Constructs the Polish locale generator.</summary>
        /// <param name="setting">Settings object used for locale IDs.</param>
        public LocalePL(Setting setting)
        {
            m_Setting = setting;
        }

        /// <summary>
        /// Generates all Polish localization entries for this mod.</summary>
        public IEnumerable<KeyValuePair<string, string>> ReadEntries(
            IList<IDictionaryEntryError> errors,
            Dictionary<string, int> indexCounts)
        {
            return new Dictionary<string, string>
            {
                // Mod title
                { m_Setting.GetSettingsLocaleID(), "Magic Mail [MM]" },

                // Tabs
                { m_Setting.GetOptionTabLocaleID(Setting.kActionsTab), "Akcje" },
                { m_Setting.GetOptionTabLocaleID(Setting.kStatusTab),  "Status" },
                { m_Setting.GetOptionTabLocaleID(Setting.kAboutTab),   "O modzie" },

                // Groups (Actions tab)
                { m_Setting.GetOptionGroupLocaleID(Setting.PostOfficeGroup),          "Poczta" },
                { m_Setting.GetOptionGroupLocaleID(Setting.PostVanGroup),             "Vany i ciężarówki" },
                { m_Setting.GetOptionGroupLocaleID(Setting.PostSortingFacilityGroup), "Sortownia" },
                { m_Setting.GetOptionGroupLocaleID(Setting.ResetGroup),               "Reset" },

                // Groups (Status tab)
                { m_Setting.GetOptionGroupLocaleID(Setting.StatusSummaryGroup), "Skan miasta" },
                { m_Setting.GetOptionGroupLocaleID(Setting.StatusActivityGroup), "Ostatnia aktywność" },

                // Groups (About tab)
                { m_Setting.GetOptionGroupLocaleID(Setting.kAboutInfoGroup),  "Informacje" },
                { m_Setting.GetOptionGroupLocaleID(Setting.kAboutLinksGroup), "Linki" },

                // ---- Post Office ----
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PO_GetLocalMail)), "Napraw niski poziom poczty lokalnej" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PO_GetLocalMail)),
                    "Gdy włączone i magazyn jest za niski, pojawia się trochę dodatkowej poczty.\n " +
                    "Nie tworzy dodatkowych vanów; trochę jak magia... ale działa :)" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PO_GettingThresholdPercentage)), "Próg poczty lokalnej" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PO_GettingThresholdPercentage)),
                    "Jeśli poczta lokalna spadnie poniżej wybranego przez ciebie procentu,\n " +
                    "urząd pocztowy dociąga więcej poczty lokalnej.\n" +
                    "To procent maksymalnej pojemności magazynu." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PO_GettingPercentage)), "Ilość pobieranej poczty lokalnej" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PO_GettingPercentage)),
                    "Procent dodawany przy pobieraniu poczty lokalnej (magiczne doładowanie).\n" +
                    "Przykład: jeśli maksimum to 10 000, a ustawisz 20%, dodane zostanie 2 000."},

                // Global overflow toggle (PO + PSF)
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.FixMailOverflow)), "Napraw przepełnienie poczty" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.FixMailOverflow)),
                    "Gdy poczty jest za dużo, obiekty robią małe magiczne sprzątanie.\n " +
                    "Nadmiarowa poczta jest traktowana jak doręczona i usuwana.\n " +
                    "To zapobiega wiecznemu \"pełne\" w budynkach.\n " +
                    "Wyłącz, aby zachować czyste zachowanie z gry (vanilla)." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PO_OverflowPercentage)), "Próg przepełnienia urzędu pocztowego" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PO_OverflowPercentage)),
                    "Gdy całkowita ilość poczty w urzędzie osiągnie ten procent,\n" +
                    "mod kasuje tyle poczty, by wrócić do tego poziomu." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PSF_OverflowPercentage)), "Próg przepełnienia sortowni" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PSF_OverflowPercentage)),
                   "Gdy całkowita ilość poczty w sortowni osiągnie ten procent,\n" +
                   "mod kasuje nadmiar, by wrócić do tego poziomu." },

                // ---- Post Vans & Trucks ----
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ChangeCapacity)), "Zmień pojemności" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ChangeCapacity)),
                    "Pozwala zmieniać pojemność vanów i ciężarówek. Gdy wyłączone,\n" +
                    "wszystkie suwaki poniżej są ukryte,\n" +
                    "a używane są wartości z gry, nawet jeśli zmieniłeś suwaki." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PostVanMailLoadPercentage)), "Ładunek pocztowego vana" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PostVanMailLoadPercentage)),
                    "Określa ile poczty może przewozić każdy van.\n" +
                    "<100% = ładunek jak w vanilla>" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PostVanFleetSizePercentage)), "Liczba pocztowych vanów" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PostVanFleetSizePercentage)),
                    "Określa ile vanów może mieć i wysyłać każdy budynek pocztowy.\n" +
                    "<100% = liczba jak w vanilla>" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.TruckCapacityPercentage)), "Liczba pocztowych ciężarówek" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.TruckCapacityPercentage)),
                    "Określa ile ciężarówek pocztowych może mieć sortownia (i inne obiekty z ciężarówkami).\n " +
                    "Maksymalna liczba jest mnożona przez ten procent.\n " +
                    "<100% = liczba jak w vanilla>" },

                // ---- Sorting Facility ----
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PSF_SortingSpeedPercentage)), "Prędkość sortowania" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PSF_SortingSpeedPercentage)),
                    "Mnożnik dla bazowej prędkości sortowania w sortowniach.\n " +
                    "<100% = wartość z vanilla>" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PSF_StorageCapacityPercentage)), "Pojemność magazynu sortowni" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PSF_StorageCapacityPercentage)),
                    "Kontroluje pojemność magazynu na pocztę.\n " +
                    "<100% = wartość z vanilla>" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PSF_GetUnsortedMail)), "Napraw niski poziom niesortowanej poczty" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PSF_GetUnsortedMail)),
                    "Po włączeniu, gdy zapasy niesortowanej poczty są zbyt niskie,\n " +
                    "pojawi się jej trochę „magicznie”.\n" +
                    "Dzięki temu sortownie dalej pracują bez czekania na dostawy.\n" +
                    "Tymczasowe obejście błędu, gdy port towarowy blokuje dopływ poczty." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PSF_GettingThresholdPercentage)), "Próg niesortowanej poczty" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PSF_GettingThresholdPercentage)),
                    "Gdy niesortowana poczta spada poniżej tego procenta pojemności,\n" +
                    "mod dociąga trochę dodatkowej niesortowanej poczty. \n" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.PSF_GettingPercentage)), "Ilość pobieranej niesortowanej poczty" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.PSF_GettingPercentage)),
                    "Dodatkowa ilość niesortowanej poczty przy pobieraniu (magiczne doładowanie).\n" +
                    "To procent maksymalnej pojemności magazynu." },

                // ---- RESET BUTTONS ----
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ResetToVanilla)), "Domyślne gry" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ResetToVanilla)),
                    "Przywraca wszystkie ustawienia do oryginalnego zachowania gry (vanilla)." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ResetToRecommend)), "Zalecane" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ResetToRecommend)),
                    "**Szybki start** – zastosuj wszystkie zalecane ustawienia poczty.\n" +
                    "Tryb easy: jedno kliknięcie i gotowe!" },

                // ---- Status tab ----
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.StatusFacilitySummary)), "" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.StatusFacilitySummary)),
                    "Podsumowanie urzędów pocztowych, vanów, sortowni i ciężarówek pocztowych\n" +
                    "obsłużonych w ostatniej aktualizacji gry (~co 45 min w grze)." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.StatusCityMailSummary)), "Poczta w mieście" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.StatusCityMailSummary)),
                    "Pokazuje ostatni przepływ poczty w całym mieście.\n\n" +
                     "**Accumulated (skumulowana)** = ile poczty wygenerowali mieszkańcy.\n" +
                     "**Processed (przetworzona)**   = ile poczty sieć faktycznie obsłużyła.\n\n" +
                     "- Jeśli Processed często jest większe niż Accumulated, sieć pocztowa daje radę.\n " +
                     "- Jeśli Accumulated przez dłuższy czas jest wyżej niż Processed, miasto generuje\n " +
                     "więcej poczty niż może obsłużyć – dodaj więcej obiektów, vanów albo zmień ustawienia." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.StatusLastActivity)), "Aktywność" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.StatusLastActivity)),
                    "Liczba pobrań poczty i czyszczeń przepełnienia z ostatniej aktualizacji." },

                // ---- About tab: info ----
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ModNameDisplay)), "Mod" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ModNameDisplay)),
                    "Wyświetlana nazwa tego modu." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.ModVersionDisplay)), "Wersja" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.ModVersionDisplay)),
                    "Aktualna wersja modu." },

                // ---- About tab: links ----
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.OpenParadox)), "Paradox" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.OpenParadox)),
                    "Otwórz stronę **Magic Mail** i innych modów na Paradox." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.OpenDiscord)), "Discord" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.OpenDiscord)),
                    "Otwórz w przeglądarce kanał **Discord** z opiniami." },
            };
        }

        /// <summary>
        /// Called when the localization source is unloaded.</summary>
        public void Unload()
        {
        }
    }
}
