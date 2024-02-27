using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2_1_Grupo_1.Models
{
    public class CountryInfo
    {
        public NameInfo Name { get; set; }
        public List<string> Tld { get; set; }
        public string Cca2 { get; set; }
        public string Ccn3 { get; set; }
        public string Cca3 { get; set; }
        public string Cioc { get; set; }
        public bool Independent { get; set; }
        public string Status { get; set; }
        public bool UnMember { get; set; }
        public CurrenciesInfo Currencies { get; set; }
        public IddInfo Idd { get; set; }
        public List<string> Capital { get; set; }
        public List<string> AltSpellings { get; set; }
        public string Region { get; set; }
        public string Subregion { get; set; }
        public LanguagesInfo Languages { get; set; }
        public TranslationsInfo Translations { get; set; }
        public List<double> Latlng { get; set; }
        public bool Landlocked { get; set; }
        public double Area { get; set; }
        public DemonymsInfo Demonyms { get; set; }
        public string Flag { get; set; }
        public MapsInfo Maps { get; set; }
        public int Population { get; set; }
        public GiniInfo Gini { get; set; }
        public string Fifa { get; set; }
        public CarInfo Car { get; set; }
        public List<string> Timezones { get; set; }
        public List<string> Continents { get; set; }
        public FlagsInfo Flags { get; set; }
        public CoatOfArmsInfo CoatOfArms { get; set; }
        public string StartOfWeek { get; set; }
        public CapitalInfo CapitalInfo { get; set; }
        public PostalCodeInfo PostalCode { get; set; }
    }

    public class NameInfo
    {
        public string Common { get; set; }
        public string Official { get; set; }
        public NativeNameInfo NativeName { get; set; }
    }

    public class NativeNameInfo
    {
        public EllInfo Ell { get; set; }
        public TurInfo Tur { get; set; }
    }

    public class EllInfo
    {
        public string Official { get; set; }
        public string Common { get; set; }
    }

    public class TurInfo
    {
        public string Official { get; set; }
        public string Common { get; set; }
    }

    public class CurrenciesInfo
    {
        public EuroInfo EUR { get; set; }
    }

    public class EuroInfo
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
    }

    public class IddInfo
    {
        public string Root { get; set; }
        public List<string> Suffixes { get; set; }
    }

    public class LanguagesInfo
    {
        public string Ell { get; set; }
        public string Tur { get; set; }
    }

    public class TranslationsInfo
    {
        public AraInfo Ara { get; set; }
        public BreInfo Bre { get; set; }
        // ... Otros idiomas ...
    }

    public class AraInfo
    {
        public string Official { get; set; }
        public string Common { get; set; }
    }

    // Implementa las clases restantes según la estructura de tu API
    // Puedes continuar el mismo patrón de clases anidadas para representar la estructura completa

    public class MapsInfo
    {
        public string GoogleMaps { get; set; }
        public string OpenStreetMaps { get; set; }
    }

    // ... Clases restantes ...

    public class FlagsInfo
    {
        public string Png { get; set; }
        public string Svg { get; set; }
        public string Alt { get; set; }
    }

    public class CoatOfArmsInfo
    {
        public string Png { get; set; }
        public string Svg { get; set; }
    }

    public class CapitalInfo
    {
        public List<double> Latlng { get; set; }
    }

    public class PostalCodeInfo
    {
        public string Format { get; set; }
        public string Regex { get; set; }
    }
}
