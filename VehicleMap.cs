﻿using AltV.Net;
using System.Collections.Generic;

namespace VenoXV.Wiki
{
    public class GtaSaVehicleModel
    {
        public string SA_VehicleModel { get; set; }
        public int SA_VehicleID { get; set; }
        public string V_VehicleModel { get; set; }
        public uint V_VehicleModelHash { get; set; }
        public string Info { get; set; }
        public GtaSaVehicleModel(string SA_VehicleModel, int SA_VehicleID, string V_VehicleModel, uint V_VehicleModelHash, string Info = "")
        {
            this.SA_VehicleModel = SA_VehicleModel;
            this.SA_VehicleID = SA_VehicleID;
            this.V_VehicleModel = V_VehicleModel;
            this.V_VehicleModelHash = V_VehicleModelHash;
            this.Info = Info;
        }
    }
    /* We create our IScript class */
    public class AltV_Wiki : IScript
    {
        private const string MODEL_DONT_EXIST = "Für dieses Fahrzeug exestiert kein ähnliches Model!";
        public static List<GtaSaVehicleModel> GtaSA_VehicleMap = new List<GtaSaVehicleModel>()
        {
            new GtaSaVehicleModel("Landstalker",    400,    "landstalker",  1269098716),
            new GtaSaVehicleModel("Bravura",        401,    "primo",        3144368207),
            new GtaSaVehicleModel("Buffalo",        402,    "dominator",    80636076),
            new GtaSaVehicleModel("Linerunner",     403,    "phantom",      2157618379),
            new GtaSaVehicleModel("Perennial",      404,    "regina",       4280472072),
            new GtaSaVehicleModel("Sentinel",       405,    "intruder",     886934177),
            new GtaSaVehicleModel("Dumper",         406,    "dump",         2164484578),
            new GtaSaVehicleModel("Firetruck",      407,    "firetruk",     1938952078),
            new GtaSaVehicleModel("Trashmaster",    408,    "trash",        1917016601),
            new GtaSaVehicleModel("Stretch",        409,    "stretch",      2333339779),
            new GtaSaVehicleModel("Manana",         410,    "intruder",     886934177),
            new GtaSaVehicleModel("Infernus",       411,    "krieger",      3630826055),
            new GtaSaVehicleModel("Voodoo",         412,    "voodoo",       2006667053),
            new GtaSaVehicleModel("Pony",           413,    "pony",         4175309224),
            new GtaSaVehicleModel("Mule",           414,    "mule",         904750859),
            new GtaSaVehicleModel("Cheetah",        415,    "bullet",       2598821281),
            new GtaSaVehicleModel("Ambulance",      416,    "ambulance",    1171614426),
            new GtaSaVehicleModel("Leviathan",      417,    "cargobob",     4244420235),
            new GtaSaVehicleModel("Moonbeam",       418,    "moonbeam",     525509695),
            new GtaSaVehicleModel("Esperanto",      419,    "virgo2",       3395457658),
            new GtaSaVehicleModel("Taxi",           420,    "taxi",         3338918751),
            new GtaSaVehicleModel("Washington",     421,    "washington",   1777363799),
            new GtaSaVehicleModel("Bobcat",         422,    "rebel",        3087195462),
            new GtaSaVehicleModel("Mr. Whoopee",    423,    "taco",         1951180813),
            new GtaSaVehicleModel("BF Injection",   424,    "bifta",        3945366167),
            new GtaSaVehicleModel("Hunter",         425,    "hunter",       4252008158),
            new GtaSaVehicleModel("Premier",        426,    "primo",        2411098011),
            new GtaSaVehicleModel("Enforcer",       427,    "policet",      456714581),
            new GtaSaVehicleModel("Securicar",      428,    "stockade",     1747439474),
            new GtaSaVehicleModel("Banshee",        429,    "banshee",      3253274834),
            new GtaSaVehicleModel("Predator",       430,    "predator",     3806844075),
            new GtaSaVehicleModel("Bus",            431,    "bus",          3581397346),
            new GtaSaVehicleModel("Rhino",          432,    "rhino",        782665360),
            new GtaSaVehicleModel("Barracks",       433,    "barracks",     3471458123),
            new GtaSaVehicleModel("Hotknife",       434,    "hotknife",     37348240),
            new GtaSaVehicleModel("Article Trailer",435,    "tvtrailer",    2524324030),
            new GtaSaVehicleModel("Previon",        436,    "primo",        2411098011),
            new GtaSaVehicleModel("Coach",          437,    "coach",        2222034228),
            new GtaSaVehicleModel("Cabbie",         438,    "taxi",         3338918751),
            new GtaSaVehicleModel("Stallion",       439,    "sentinel",     1349725314),
            new GtaSaVehicleModel("Rumpo",          440,    "rumpo",        1162065741),
            new GtaSaVehicleModel("RC Bandit",      441,    "rcbandito",    4008920556),
            new GtaSaVehicleModel("Romero",         442,    "romero",       627094268),
            new GtaSaVehicleModel("Packer",         443,    "Packer",       569305213),
            new GtaSaVehicleModel("Monster",        444,    "sandking",     3105951696),
            new GtaSaVehicleModel("Admiral",        445,    "intruder",     886934177),
            new GtaSaVehicleModel("Squallo",        446,    "squalo",       400514754),
            new GtaSaVehicleModel("Seasparrow",     447,    "seasparrow",   3568198617),
            new GtaSaVehicleModel("Pizzaboy",       448,    "faggio",       2452219115),
            new GtaSaVehicleModel("Tram",           449,    "metrotrain",   868868440),
            new GtaSaVehicleModel("ArticleTrailer2",450,    "trailers4",    3194418602),
            new GtaSaVehicleModel("Turismo",        451,    "turismo2",     3312836369),
            new GtaSaVehicleModel("Speeder",        452,    "speeder",      231083307),
            new GtaSaVehicleModel("Reefer",         453,    "marquis",      3251507587),
            new GtaSaVehicleModel("Tropic",         454,    "marquis",      3251507587),
            new GtaSaVehicleModel("Flatbed",        455,    "Flatbed",      1353720154),
            new GtaSaVehicleModel("Yankee",         456,    "mule",         904750859),
            new GtaSaVehicleModel("Caddy",          457,    "caddy",        1147287684),
            new GtaSaVehicleModel("Solair",         458,    "stratum",      1723137093),
            new GtaSaVehicleModel("Topfun Van",     459,    "pony",         4175309224),
            new GtaSaVehicleModel("Skimmer",        460,    "duster",       970356638),
            new GtaSaVehicleModel("PCJ-600",        461,    "pcj",          3385765638),
            new GtaSaVehicleModel("Faggio",         462,    "faggio",       2452219115),
            new GtaSaVehicleModel("Freeway",        463,    "hexer",        301427732),
            new GtaSaVehicleModel("RC Baron",       464,    "rcbandito",    4008920556, MODEL_DONT_EXIST),
            new GtaSaVehicleModel("RC Raider",      465,    "rcbandito",    4008920556, MODEL_DONT_EXIST),
            new GtaSaVehicleModel("Glendale",       466,    "glendale",     75131841),
            new GtaSaVehicleModel("Oceanic",        467,    "washington",   1777363799),
            new GtaSaVehicleModel("Sanchez",        468,    "sanchez",      788045382),
            new GtaSaVehicleModel("Sparrow",        469,    "seasparrow",   3568198617),
            new GtaSaVehicleModel("Patriot",        470,    "crusader",     321739290),
            new GtaSaVehicleModel("Quad",           471,    "blazer",       2166734073),
            new GtaSaVehicleModel("Coastguard",     472,    "toro2",        908897389),
            new GtaSaVehicleModel("Dinghy",         473,    "dinghy",       1033245328),
            new GtaSaVehicleModel("Hermes",         474,    "hermes",       15219735),
            new GtaSaVehicleModel("Sabre",          475,    "sabregt",      2609945748),
            new GtaSaVehicleModel("Rustler",        476,    "duster",       970356638),
            new GtaSaVehicleModel("ZR-350",         477,    "furoregt",     3205927392),
            new GtaSaVehicleModel("Walton",         478,    "dloader",      1770332643),
            new GtaSaVehicleModel("Regina",         479,    "regina",       4280472072),
            new GtaSaVehicleModel("Comet",          480,    "comet2",       3249425686),
            new GtaSaVehicleModel("BMX",            481,    "bmx",          1131912276),
            new GtaSaVehicleModel("Burrito",        482,    "burrito2",     3387490166),
            new GtaSaVehicleModel("Camper",         483,    "surfer",       699456151),
            new GtaSaVehicleModel("Marquis",        484,    "marquis",      3251507587),
            new GtaSaVehicleModel("Baggage",        485,    "airtug",       1560980623),
            new GtaSaVehicleModel("Dozer",          486,    "bulldozer",    1886712733),
            new GtaSaVehicleModel("Maverick",       487,    "maverick",     2634305738),
            new GtaSaVehicleModel("SANNewsMaverick",488,    "maverick",     2634305738),
            new GtaSaVehicleModel("Rancher",        489,    "rancherxl",    1645267888),
            new GtaSaVehicleModel("Rancher",        490,    "fbi2",         2647026068),
            new GtaSaVehicleModel("Virgo",          491,    "virgo2",       3395457658),
            new GtaSaVehicleModel("Greenwood",      492,    "virgo2",       3395457658),
            new GtaSaVehicleModel("Jetmax",         493,    "jetmax",       861409633),
            new GtaSaVehicleModel("Hotring Racer",  494,    "dominator2",   3379262425),
            new GtaSaVehicleModel("Sandking",       495,    "landstalker2", 3456868130),
            new GtaSaVehicleModel("BlistaCompact",  496,    "blista2",      1039032026),
            new GtaSaVehicleModel("Police Maverick",497,    "maverick",     2634305738),
            new GtaSaVehicleModel("Boxville",       498,    "boxville2",    4061868990),
            new GtaSaVehicleModel("Benson",         499,    "boxville2",    4061868990),
            new GtaSaVehicleModel("Mesa",           500,    "mesa",         914654722),
            new GtaSaVehicleModel("RC Goblin",      501,    "rcbandito",    4008920556),
            new GtaSaVehicleModel("HotringRacerA",  502,    "dominator2",   3379262425),
            new GtaSaVehicleModel("HotringRacerB",  503,    "dominator2",   3379262425),
            new GtaSaVehicleModel("BloodringBanger",504,    "mamba",        2634021974),
            new GtaSaVehicleModel("Rancher Lure",   505,    "seminole2",    2484160806),
            new GtaSaVehicleModel("Super GT",       506,    "elegy2",       3728579874),
            new GtaSaVehicleModel("Elegant",        507,    "primo",        3144368207),
            new GtaSaVehicleModel("Journey",        508,    "journey",      4174679674),
            new GtaSaVehicleModel("Bike",           509,    "scorcher",     4108429845),
            new GtaSaVehicleModel("Mountain Bike",  510,    "tribike3",     3894672200),
            new GtaSaVehicleModel("Beagle",         511,    "mogul",        3545667823),
            new GtaSaVehicleModel("Cropduster",     512,    "tula",         1043222410),
            new GtaSaVehicleModel("Stuntplane",     513,    "tula",         1043222410),
            new GtaSaVehicleModel("Tanker",         514,    "Packer",       569305213),
            new GtaSaVehicleModel("Roadtrain",      515,    "Packer",       569305213),
            new GtaSaVehicleModel("Nebula",         516,    "primo",        2411098011),
            new GtaSaVehicleModel("Majestic",       517,    "faction2",     2504420315),
            new GtaSaVehicleModel("Buccaneer",      518,    "buccaneer",    3612755468),
            new GtaSaVehicleModel("Shamal",         519,    "shamal",       3080461301),
            new GtaSaVehicleModel("Hydra",          520,    "hydra",        970385471),
            new GtaSaVehicleModel("FCR-900",        521,    "fcr",          627535535),
            new GtaSaVehicleModel("NRG-500",        522,    "hakuchou",     1265391242),
            new GtaSaVehicleModel("HPV1000",        523,    "policeb",      4260343491),
            new GtaSaVehicleModel("Cement Truck",   524,    "mixer",        3510150843),
            new GtaSaVehicleModel("Towtruck",       525,    "towtruck",     2971866336),
            new GtaSaVehicleModel("Fortune",        526,    "intruder",     886934177),
            new GtaSaVehicleModel("Cadrona",        527,    "oracle2",      3783366066),
            new GtaSaVehicleModel("FBI Truck",      528,    "sheriff2",     1922257928, MODEL_DONT_EXIST),
            new GtaSaVehicleModel("Willard",        529,    "washington",   1777363799),
            new GtaSaVehicleModel("Forklift",       530,    "forklift",     1491375716),
            new GtaSaVehicleModel("Tractor",        531,    "tractor2",     2218488798),
            new GtaSaVehicleModel("Harvester",      532,    "tractor2",     2218488798, MODEL_DONT_EXIST),
            new GtaSaVehicleModel("Feltzer",        533,    "sentinel2",    873639469),
            new GtaSaVehicleModel("Remington",      534,    "virgo2",       3395457658),
            new GtaSaVehicleModel("Slamvan",        535,    "slamvan",      729783779),
            new GtaSaVehicleModel("Blade",          536,    "buccaneer2",   3281516360),
            new GtaSaVehicleModel("Freight",        537,    "freight",      1030400667),
            new GtaSaVehicleModel("Brownstreak",    538,    "freight",      1030400667),
            new GtaSaVehicleModel("Vortex",         539,    "freight",      1030400667, MODEL_DONT_EXIST),
            new GtaSaVehicleModel("Vincent",        540,    "primo",        3144368207),
            new GtaSaVehicleModel("Bullet",         541,    "bullet",       2598821281),
            new GtaSaVehicleModel("Clover",         542,    "buccaneer",    3612755468),
            new GtaSaVehicleModel("Sadler",         543,    "sadler",       3695398481),
            new GtaSaVehicleModel("Firetruck LA",   544,    "firetruk",     1938952078),
            new GtaSaVehicleModel("Hustler",        545,    "hustler",      600450546),
            new GtaSaVehicleModel("Intruder",       546,    "intruder",     886934177),
            new GtaSaVehicleModel("Primo",          547,    "primo",        2411098011),
            new GtaSaVehicleModel("Cargobob",       548,    "cargobob",     4244420235),
            new GtaSaVehicleModel("Tampa",          549,    "tampa",        972671128),
            new GtaSaVehicleModel("Sunrise",        550,    "primo",        3144368207),
            new GtaSaVehicleModel("Merit",          551,    "zion2",        3101863448),
            new GtaSaVehicleModel("Utility Van",    552,    "utillitruck3", 2132890591),
            new GtaSaVehicleModel("Nevada",         553,    "cuban800",     3650256867),
            new GtaSaVehicleModel("Yosemite",       554,    "yosemite3",    67753863),
            new GtaSaVehicleModel("Windsor",        555,    "windsor",      1581459400),
            new GtaSaVehicleModel("MonsterA",       556,    "sandking",     3105951696),
            new GtaSaVehicleModel("MonsterB",       557,    "sandking",     3105951696),
            new GtaSaVehicleModel("Uranus",         558,    "bestiagts",    1274868363),
            new GtaSaVehicleModel("Jester",         559,    "jester3",      4080061290),
            new GtaSaVehicleModel("Sultan",         560,    "sultan",       970598228),
            new GtaSaVehicleModel("Stratum",        561,    "stratum",      1723137093),
            new GtaSaVehicleModel("Elegy",          562,    "elegy2",       3728579874),
            new GtaSaVehicleModel("Raindance",      563,    "swift",        3955379698),
            new GtaSaVehicleModel("RC Tiger",       564,    "rcbandito",    4008920556, MODEL_DONT_EXIST),
            new GtaSaVehicleModel("Flash",          565,    "bjxl",         850565707),
            new GtaSaVehicleModel("Tahoma",         566,    "manana",       2170765704),
            new GtaSaVehicleModel("Savanna",        567,    "manana",       2170765704),
            new GtaSaVehicleModel("Bandito",        568,    "outlaw",       408825843),
            new GtaSaVehicleModel("FlatTrailer",    569,    "freight",      3517691494),
            new GtaSaVehicleModel("StreakTrailer",  570,    "freightcont1", 920453016),
            new GtaSaVehicleModel("Kart",           571,    "rcbandito",    4008920556),
            new GtaSaVehicleModel("Mower",          572,    "mower",        1783355638),
            new GtaSaVehicleModel("Dune",           573,    "mule",         904750859),
            new GtaSaVehicleModel("Sweeper",        574,    "brioso",       1549126457),
            new GtaSaVehicleModel("Broadway",       575,    "hermes",       15219735),
            new GtaSaVehicleModel("Tornado",        576,    "tornado",      464687292),
            new GtaSaVehicleModel("AT400",          577,    "jet",          1058115860),
            new GtaSaVehicleModel("DFT-30",         578,    "flatbed",      1353720154),
            new GtaSaVehicleModel("Huntley",        579,    "huntley",      486987393),
            new GtaSaVehicleModel("Stafford",       580,    "stafford",     321186144),
            new GtaSaVehicleModel("BF-400",         581,    "bf400",        86520421),
            new GtaSaVehicleModel("Newsvan",        582,    "burrito2",     3387490166),
            new GtaSaVehicleModel("Tug",            583,    "Tug",          1783355638),
            new GtaSaVehicleModel("PetrolTrailer",  584,    "tanker",       3564062519),
            new GtaSaVehicleModel("Emperor",        585,    "emperor",      3609690755),
            new GtaSaVehicleModel("Wayfarer",       586,    "bagger",       2154536131),
            new GtaSaVehicleModel("Euros",          587,    "prairie",      2844316578),
            new GtaSaVehicleModel("Hotdog",         588,    "taco",         1951180813),
            new GtaSaVehicleModel("Club",           589,    "club",         2196012677),
            new GtaSaVehicleModel("Freight Box",    590,    "trailers4",    3194418602),
            new GtaSaVehicleModel("ArticleTrailer3",591,    "docktrailer",  2154757102),
            new GtaSaVehicleModel("Andromada",      592,    "cargoplane",   368211810),
            new GtaSaVehicleModel("Dodo",           593,    "dodo",         3393804037),
            new GtaSaVehicleModel("RC Cam",         594,    "rcbandito",    4008920556, MODEL_DONT_EXIST),
            new GtaSaVehicleModel("Launch",         595,    "marquis",      3251507587),
            new GtaSaVehicleModel("PoliceCar",      596,    "police3",      1912215274),
            new GtaSaVehicleModel("PoliceCar(SFPD)",597,    "police3",      1912215274),
            new GtaSaVehicleModel("PoliceCar(LVPD)",598,    "police",       2046537925),
            new GtaSaVehicleModel("Police Ranger",  599,    "sheriff2",     1922257928),
            new GtaSaVehicleModel("Picador",        600,    "picador",      1507916787),
            new GtaSaVehicleModel("S.W.A.T.",       601,    "riot",         3089277354),
            new GtaSaVehicleModel("Alpha",          602,    "alpha",        767087018),
            new GtaSaVehicleModel("Phoenix",        603,    "phoenix",      2199527893),
            new GtaSaVehicleModel("GlendaleShit",   604,    "glendale",     75131841),
            new GtaSaVehicleModel("SadlerShit",     605,    "sadler",       3695398481),
            new GtaSaVehicleModel("BaggageTrailerA",606,    "trailersmall", 712162987),
            new GtaSaVehicleModel("BaggageTrailerB",607,    "trailersmall", 712162987),
            new GtaSaVehicleModel("TugStairs",      608,    "trailersmall", 712162987, MODEL_DONT_EXIST),
            new GtaSaVehicleModel("Boxville",       609,    "boxville",     2307837162),
            new GtaSaVehicleModel("Farm Trailer",   610,    "rcbandito",    4008920556, MODEL_DONT_EXIST),
            new GtaSaVehicleModel("Utility Trailer",611,    "trailersmall", 712162987, MODEL_DONT_EXIST),
        };
        // Enjoy ^-^
    }
}
