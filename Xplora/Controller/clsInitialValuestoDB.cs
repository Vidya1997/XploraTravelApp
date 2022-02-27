using System;
using System.Collections.Generic;
using System.Text;
using Xplora.Model;

namespace Xplora.Controller
{
    public class clsInitialValuestoDB
    {
        public List<tblStates> p_states = new List<tblStates>();
        public List<tblPlaces> p_places = new List<tblPlaces>();
        public List<tblPackage> p_packages = new List<tblPackage>();
        public List<tblDistricts> p_Districts = new List<tblDistricts>();
        public List<tblRestaurants> p_restaurants = new List<tblRestaurants>();
        public clsInitialValuestoDB()
        {
            p_states.Clear();
            p_places.Clear();
            p_packages.Clear();
            p_Districts.Clear();
            p_restaurants.Clear();
            pro_ReloadStates();
            pro_ReloadPlaces();
            pro_ReloadPackages();
            pro_ReloadDistricts();
            pro_ReloadRestaurants();
        }
        private async void pro_ReloadStates()
        {
            p_states = await App.ent_Database.pro_getStates();
            if (p_states.Count == 0)
            {
                pro_AddStates();
            }
        }
        private async void pro_AddStates()
        {
            await App.ent_Database.pro_saveState(pro_State("Andhra Pradesh")); //1
            await App.ent_Database.pro_saveState(pro_State("Arunachal Pradesh")); //2
            await App.ent_Database.pro_saveState(pro_State("Assam")); //3
            await App.ent_Database.pro_saveState(pro_State("Bihar")); //4
            await App.ent_Database.pro_saveState(pro_State("Chhattisgarh")); //5
            await App.ent_Database.pro_saveState(pro_State("Goa")); //6
            await App.ent_Database.pro_saveState(pro_State("Gujarat")); //7
            await App.ent_Database.pro_saveState(pro_State("Haryana")); //8
            await App.ent_Database.pro_saveState(pro_State("Himachal Pradesh")); //9
            await App.ent_Database.pro_saveState(pro_State("Jharkhand")); //10
            await App.ent_Database.pro_saveState(pro_State("Karnataka")); //11 
            await App.ent_Database.pro_saveState(pro_State("Kerala")); //12
            await App.ent_Database.pro_saveState(pro_State("Madhya Pradesh")); //13
            await App.ent_Database.pro_saveState(pro_State("Maharashtra")); //14
            await App.ent_Database.pro_saveState(pro_State("Manipur")); //15
            await App.ent_Database.pro_saveState(pro_State("Meghalaya")); //16
            await App.ent_Database.pro_saveState(pro_State("Mizoram")); //17
            await App.ent_Database.pro_saveState(pro_State("Nagaland")); //18
            await App.ent_Database.pro_saveState(pro_State("Odisha")); //19
            await App.ent_Database.pro_saveState(pro_State("Punjab")); //20
            await App.ent_Database.pro_saveState(pro_State("Rajasthan")); //21
            await App.ent_Database.pro_saveState(pro_State("Sikkim")); //22
            await App.ent_Database.pro_saveState(pro_State("Tamil Nadu")); //23
            await App.ent_Database.pro_saveState(pro_State("Telangana")); //24
            await App.ent_Database.pro_saveState(pro_State("Tripura")); //25
            await App.ent_Database.pro_saveState(pro_State("Uttar Pradesh")); //26
            await App.ent_Database.pro_saveState(pro_State("Uttarakhand")); //27
            await App.ent_Database.pro_saveState(pro_State("West Bengal")); //28
        }
        private tblStates pro_State(string a_StateName)
        {
            tblStates tblStates = new tblStates()
            {
                fldState = a_StateName,
            };
            return tblStates;
        }
        private async void pro_ReloadPlaces()
        {
            p_places = await App.ent_Database.pro_getPlaces(); ;
            if (p_places.Count == 0)
            {
                pro_AddPlaces();
            }
        }
        private async void pro_AddPlaces()
        {
            await App.ent_Database.pro_savePlaces(pro_Places("Bengaluru Fort", "FortressKrishna Rajendra Rd", "Fort", 4));
            await App.ent_Database.pro_savePlaces(pro_Places("Bangalore Palace", "Vasanth Nagar, Bengaluru, Karnataka 560052", "Historic Place", 4));
            await App.ent_Database.pro_savePlaces(pro_Places("Tree Fossil", "MavalliBengaluru, Karnataka 560004", "Garden", 4));
            await App.ent_Database.pro_savePlaces(pro_Places("Lalbagh Botanical Garden", "Mavalli, Bengaluru, Karnataka 560004", "Park", 4));
            await App.ent_Database.pro_savePlaces(pro_Places("Floral Clock", "Lal Bagh Main Rd, Mavalli, Bengaluru, Karnataka 560004", "Park", 4));
            await App.ent_Database.pro_savePlaces(pro_Places("Bugle Rock Park", "Bull Temple Rd, Basavanagudi, Bengaluru, Karnataka 560019", "Park", 4));
            await App.ent_Database.pro_savePlaces(pro_Places("Cubbon Park", "Kasturba Road, Behind High Court of Karnataka Ambedkar Veedhi, Sampangi Rama Nagara, Bengaluru, Karnataka 560001", "Park", 4));
            await App.ent_Database.pro_savePlaces(pro_Places("Kempegowda Museum", "Field Marshal Cariappa Rd, Shanthala Nagar, Ashok Nagar, Bengaluru, Karnataka 560001", "Museum", 4));
            await App.ent_Database.pro_savePlaces(pro_Places("ISKCON Temple Bangalore", "Hare Krishna Hill, Chord Rd, Rajajinagar, Bengaluru, Karnataka 560010", "Temple", 4));
            await App.ent_Database.pro_savePlaces(pro_Places("Tipu Sultan's Summer Palace", "Tippu Sultan Palace Rd, Chamrajpet, Bengaluru, Karnataka 560018", "Palace", 4)); //10
            await App.ent_Database.pro_savePlaces(pro_Places("Government Aquarium", "Kasturba Rd, Shanthala Nagar, Bengaluru, Karnataka 560001", "Aquarium", 4));
            await App.ent_Database.pro_savePlaces(pro_Places("Thottikallu Falls", "Kanakapura Rd, Bengaluru, Karnataka 560083", "Falls", 4));
            await App.ent_Database.pro_savePlaces(pro_Places("‌Jinke Park", "Nanjamba Agrahara, Kempegowda Nagar, Bengaluru, Karnataka 560019", "Park", 4));
            await App.ent_Database.pro_savePlaces(pro_Places("Jawaharlal Nehru Planetarium", "Sri T, Sankey Rd, High Grounds, Bengaluru, Karnataka 560001", "Planetarium", 4));
            await App.ent_Database.pro_savePlaces(pro_Places("Mahatmagandhi Park", "Shivaji Nagar, Bengaluru, Karnataka 560001", "Park", 4));
            await App.ent_Database.pro_savePlaces(pro_Places("Freedom Park", "Seshadri Rd, Gandhi Nagar, Bengaluru, Karnataka 560009", "Park", 4));
            await App.ent_Database.pro_savePlaces(pro_Places("Dancing And Musical Fountain Bangalore", "The Deputy Director of Horticulture,Cubbon Park, Bengaluru, Karnataka 560052", "Musical Fountain", 4));
            await App.ent_Database.pro_savePlaces(pro_Places("Bannerghatta Safari", "Bengaluru, Karnataka 562112", "Park", 4));
            await App.ent_Database.pro_savePlaces(pro_Places("Fun World Amusement Park", "Palace Grounds, Jayamahal Main Rd, Opposite TV Tower, J.C.Nagar, Bengaluru, Karnataka 560006", "Park", 4));
            await App.ent_Database.pro_savePlaces(pro_Places("Sumadhura Eden Garden", "Doddabanahalli, Marathahalli - Sarjapur Outer Ring Rd, Whitefield", "Garden", 4)); //10
            await App.ent_Database.pro_savePlaces(pro_Places("Wonderla Amusement Park", "Mysore Rd, Bengaluru", "Park", 4));
            await App.ent_Database.pro_savePlaces(pro_Places("Mahatmagandhi Park", "Shivaji Nagar, Bengaluru", "Park", 4));
            await App.ent_Database.pro_savePlaces(pro_Places("St. Mary's Basilica", "Shivaji Nagar, Bengaluru, Karnataka 560051", "church", 4));
            await App.ent_Database.pro_savePlaces(pro_Places("Turahalli Forest", "Thurahalli, Bengaluru, Karnataka 560062", "Forest", 4));
            await App.ent_Database.pro_savePlaces(pro_Places("Begur Fort", "Akshaya Residency, Akshayanagar, Bengaluru, Karnataka 560076", "Fort", 4));
            await App.ent_Database.pro_savePlaces(pro_Places("Ashoka Pillar Monument", "Kankanpalya Rd, 2nd Block, Mavalli, Bengaluru, Karnataka 560004", "Historic Place", 4));
            await App.ent_Database.pro_savePlaces(pro_Places("Kempegowda Tower", "Sampangi Rama Nagar, Ambedkar Veedhi, Bengaluru, Karnataka 560001", "Tower", 4));
            await App.ent_Database.pro_savePlaces(pro_Places("Bannerghatta Biological Park", "Bannerghatta Main Rd, Bannerughatta, Bengaluru", "Park", 4));
            await App.ent_Database.pro_savePlaces(pro_Places("Jp Park", "Subedarpalya, Mathikere, Bengaluru", "Park", 4));
            await App.ent_Database.pro_savePlaces(pro_Places("Dodda Aalada Mara", "Tavarekere, Dodda Aladmara Road, Uttarahalli Hobli", "Park", 4)); //10
            await App.ent_Database.pro_savePlaces(pro_Places("Sri Gavi Gangadhareshwara Devastana", "5th Main Rd, Gavipuram Extention, Kempegowda Nagar, Bengaluru, Karnataka 560019", "Temple", 4));
            await App.ent_Database.pro_savePlaces(pro_Places("Venkatappa Art Gallery Bengaluru", "Kasturba Rd, Ambedkar Veedhi, Sampangi Rama Nagar, Bengaluru, Karnataka 560001", "Art Gallery", 4));
            await App.ent_Database.pro_savePlaces(pro_Places("Sri Someshwara Swamy Temple", "Someshwara Temple Rd, Someshwarpura, Halasuru, Karnataka 560008", "Temple", 4));
            //keraladistrict no:
            await App.ent_Database.pro_savePlaces(pro_Places("Arakkal Museum Kannur", " Ayikkara Government Hospital Road Ayikkara, near District Hospital, Kannur, Kerala 670013", "Museum", 29));
            await App.ent_Database.pro_savePlaces(pro_Places("Baby Beach", " Kannur Cantonment Area, Burnacherry, Kannur, Kerala 670013", "Beach", 29));

            await App.ent_Database.pro_savePlaces(pro_Places("Mallikarjuna Temple", "Kasaragod, Kerala 671123", "Temple", 30));
            await App.ent_Database.pro_savePlaces(pro_Places("Maipady Palace", "Maipady Palace, Vidyanagar – Maipady – Seethangoly Rd, Kasaragod, Kerala 671124", "palace", 30));
            await App.ent_Database.pro_savePlaces(pro_Places("Adventure Park, Kollam", "Behind, Guest House Rd, Asramam, Kollam, Kerala 691001", "Park", 31));
            await App.ent_Database.pro_savePlaces(pro_Places("Thevally Palace", "Kollam - Elamballoor Road, Palace Nagar, Thevally, Kollam, Kerala 691009", "Palace", 31));
            await App.ent_Database.pro_savePlaces(pro_Places("Thirunakkara Mahadeva Temple", "Temple Rd, Thirunakara, Kottayam, Kerala 686001", "Temple", 32)); //10
            await App.ent_Database.pro_savePlaces(pro_Places("Kottayam Water Park", "Kodimatha, Kottayam, Kerala 686001", "Water Park", 32));
            await App.ent_Database.pro_savePlaces(pro_Places("SAROVARAM BIOPARK", "Mini Bypass Rd, Kottooli, Kozhikode, Kerala 673017", "Park", 34));
            await App.ent_Database.pro_savePlaces(pro_Places("Kozhikode Beach Light House", "Kozhikode Beach Lighthouse, opposite port Office, Vellayil, Kozhikode, Kerala 673032", "Beach", 34));
            await App.ent_Database.pro_savePlaces(pro_Places("Madhavaraja Palace", "College Rd, Vidyut Nagar, Palakkad, Kerala 678001", "Palace", 35));
            await App.ent_Database.pro_savePlaces(pro_Places("Palakkad Fort", "Palakkad-Koduvayur, Thathamangalam-Meenakshipuram Highway, Kenathuparambu, Kunathurmedu, Palakkad, Kerala 678001", "Fort", 35));
            await App.ent_Database.pro_savePlaces(pro_Places("Kudalasangama", "Almatti Dam in Bagalkot district of Karnataka state.", "Historic place", 1));
            await App.ent_Database.pro_savePlaces(pro_Places("Museum and Cultural Hall", "near radhakrishna temple, Sector 18, Nava Nagar, Bagalkote, Karnataka 587103", "Temple", 1));
            await App.ent_Database.pro_savePlaces(pro_Places("Fort", "Devi Nagar, Ballari, Karnataka 583104", "Historic place", 2));
            await App.ent_Database.pro_savePlaces(pro_Places("Ballari Mini Zoo", "Aishwarya Colony, Cantonment, Ballari, Karnataka 583104", "zoo", 2));
            await App.ent_Database.pro_savePlaces(pro_Places("Belagavi Fort", "Belgaum Fort Area, Belagavi, Karnataka 590016", "Fort", 3)); //10
            await App.ent_Database.pro_savePlaces(pro_Places("Sharquat Park", "P 112/1, Queens Garden Rd, Laxmi Tek, Camp, Belagavi, Karnataka 590001", "Park", 3));
            await App.ent_Database.pro_savePlaces(pro_Places("Barachukki Waterfalls", "Chamarajnagar, Karnataka 571430", "Waterfalls", 6));
            await App.ent_Database.pro_savePlaces(pro_Places("Chamarajeshwara Temple", "Car St, Galipur, Chamarajanagar, Karnataka 571313", "Temple", 6));
            await App.ent_Database.pro_savePlaces(pro_Places("Nandi Hill", "Nandi Hills, Karnataka 562103", "Historic place", 7));
            await App.ent_Database.pro_savePlaces(pro_Places("Kethenahalli Falls", "Marappanahalli, Karnataka 561211", "Waterfalls", 7));
            await App.ent_Database.pro_savePlaces(pro_Places("Hebbe Waterfalls", "Chikkamagaluru District, Kesavinamane, Karnataka 577131", "Waterfalls", 8));
            await App.ent_Database.pro_savePlaces(pro_Places("Jhari Waterfall", "Thippanahalli Estate Rd, Inam Dattathreya Peeta, Karnataka 577131", "Waterfalls", 8));
            await App.ent_Database.pro_savePlaces(pro_Places("Chitradurga Fort", "Chitradurga, Karnataka 577501", "Fort", 9));
            await App.ent_Database.pro_savePlaces(pro_Places("kamana Bagilu", "fort, Chickpet, Chitradurga, Karnataka 577501", "Historic place", 9));
            await App.ent_Database.pro_savePlaces(pro_Places("Didupe / Kadamagundi falls", "Chavadi Rd, Karnataka 574214", "Waterfalls", 10)); //10
            await App.ent_Database.pro_savePlaces(pro_Places("Narahari Parvatha Sri Sadashiva Temple", "Karnataka 574231", "Temple", 10));
            await App.ent_Database.pro_savePlaces(pro_Places("SRI CHOWDWSHWARI TEMPLE", "Mustafa Nagar, Davanagere, Karnataka 577002", "Temple", 11));
            await App.ent_Database.pro_savePlaces(pro_Places("Eshwara Temple", "Nittuvalli, Davanagere, Karnataka 577002", "Temple", 11));
            await App.ent_Database.pro_savePlaces(pro_Places("Mylarlinga Temple", "Dead Race, Daneshwari Nagar, Vidyagiri, Dharwad, Karnataka 580004", "Temple", 12));
            await App.ent_Database.pro_savePlaces(pro_Places("Durga Devi Temple", "2/347, Siruvani Main Rd, Durga nagar, Kalampalayam,", "Temple", 12));
            await App.ent_Database.pro_savePlaces(pro_Places("Hasanamba Temple", "Hosaline Rd, Ammeer Mohalla, Hassan, Karnataka 573201", "Temple", 14));
            await App.ent_Database.pro_savePlaces(pro_Places("Maharaja Park", "Rangoli Halla, Hassan, Karnataka 573201", "Park", 14));
            await App.ent_Database.pro_savePlaces(pro_Places("Chelavara Water Falls", "Cheyyandane village, Chelavara, Karnataka 571212", "Waterfalls", 14));
            await App.ent_Database.pro_savePlaces(pro_Places("Abbey Falls", "near rto office, Madikeri, Karnataka 571201", "Waterfalls", 15));
            await App.ent_Database.pro_savePlaces(pro_Places("Anthargange falls", "Antharagange Main Rd, Vibhuthipura, Karnataka 563101", "Waterfalls", 15)); //10
            await App.ent_Database.pro_savePlaces(pro_Places("Challahalli falls", "Kolar, Karnataka 563101", "Waterfalls", 17));
            await App.ent_Database.pro_savePlaces(pro_Places("Hulikeri Park", "Koppal, Karnataka 583231", "Park", 18));
            await App.ent_Database.pro_savePlaces(pro_Places("Sri gavisiddeshwara swami maha dwara", "Gavi Math Road, B.T.Patil Nagar, Koppal, Karnataka 583231", "Temple", 18));
            await App.ent_Database.pro_savePlaces(pro_Places("Shri Ganesha Temple", "Kalahalli Rd, V V Nagar, Mandya, Karnataka 571401", "Temple", 19));
            await App.ent_Database.pro_savePlaces(pro_Places("Hanuman Temple", "Petebeedhi, Mandya, Karnataka 571401", "Temple", 19));
            await App.ent_Database.pro_savePlaces(pro_Places("Mysore Palace", "Sayyaji Rao Rd, Agrahara, Chamrajpura, Mysuru, Karnataka 570001", "Palace", 20));
            await App.ent_Database.pro_savePlaces(pro_Places("Sri Chamarajendra Zoological Gardens", "Zoo Main Road, Indira Nagar, Ittige Gudu, Mysuru, Karnataka", "Garden", 20));
            await App.ent_Database.pro_savePlaces(pro_Places("Sri Nandishwara Temple", "Bommanwadi, Indira Nagar, Raichur, Karnataka 584103", "Temple", 21));
            await App.ent_Database.pro_savePlaces(pro_Places("Raichur Fort", "Androon Quilla, Raichur, Karnataka 584101", "Fort", 21));
            await App.ent_Database.pro_savePlaces(pro_Places("Ramanagara Ramdevara Betta Vulture Sanctuary", "Shri Phatthabi Rama Temple Sri Rama Hill, Thibbegowdanadoddi, Ramanagara, Karnataka 562159", "Temple", 22)); //10
            await App.ent_Database.pro_savePlaces(pro_Places("Rangarayana Doddi Lake Boating", "Bolappanahalli, Karnataka 562159", "Lake", 22));
            await App.ent_Database.pro_savePlaces(pro_Places("Shivappa Nayaka Palace Museum", "Double Road, SPM Rd, Lashkar Mohalla, KR Puram, Shivamogga, Karnataka 577202", "Museum", 23));
            await App.ent_Database.pro_savePlaces(pro_Places("GANDHI PARK", "Gandhi park, Durgigudi, Shivamogga, Karnataka 577201", "Park", 23));
            await App.ent_Database.pro_savePlaces(pro_Places("Kote Anjaneya Statue", "SH 33, Chickpet, Tumakuru, Karnataka 572101", "Temple", 24));
            await App.ent_Database.pro_savePlaces(pro_Places("D Bamboo forest tumkuru", "Tumakuru, Karnataka 572140", "Park", 24));
            await App.ent_Database.pro_savePlaces(pro_Places("Suvarna River Bank", "Udupi, Karnataka 576105", "River bank", 25)); //52
            await App.ent_Database.pro_savePlaces(pro_Places("Shri Krishna Matha", "Temple Car St, Sri Krishna Temple Complex, Thenkpete, Maruthi Veethika, Udupi, Karnataka 576101", "Temple", 25));
            await App.ent_Database.pro_savePlaces(pro_Places("Sathodi Falls", "Balagar, Karnataka 581337", "Waterfalls", 26));
            await App.ent_Database.pro_savePlaces(pro_Places("Burude Falls", "Illimane, Burude falls road, Siddapura, Karnataka 581355", "Waterfalls", 26));
            await App.ent_Database.pro_savePlaces(pro_Places("Thimmarayaswamy hill steps", "Kodalagurki, Karnataka 562110", "Historic Place", 27)); //10
            await App.ent_Database.pro_savePlaces(pro_Places("Sri Lakshmi Venkataramana Swami Temple", "Balija Road, Vijayapura Town, Karnataka 562135", "Temple", 27));
            await App.ent_Database.pro_savePlaces(pro_Places("Shree Ramalingeshwara Temple Yergole", "Yadgir, Karnataka 585218", "Temple", 28));
            await App.ent_Database.pro_savePlaces(pro_Places("Lumbini Park", "585201 02, Yadgir, Karnataka", "Park", 28));
            //await App.ent_Database.pro_savePlaces(pro_Places("", "", "", 39));

            await App.ent_Database.pro_savePlaces(pro_Places("Murugan Temple", "Shanthi Nagar East, Ariyalur, Tamil Nadu 635109", "Temple", 39));
            await App.ent_Database.pro_savePlaces(pro_Places("Walkers Park", "Rama Naicken Lake, Ariyalur, Tamil Nadu", "Park", 39));
            await App.ent_Database.pro_savePlaces(pro_Places("Kalikambal Kamateswarar Temple", "chennai, Tamil Nadu 635109", "Temple", 40));
            await App.ent_Database.pro_savePlaces(pro_Places("Dakshina Tirupati Temple", " Gopasandram- Kamandoodi, chennai Tamil Nadu 635130", "Temple", 40));
            await App.ent_Database.pro_savePlaces(pro_Places("VOC park and zoo", "24, Jail Road, ATT Colony, Gopalapuram, Coimbatore,", "Zoo", 41));
            await App.ent_Database.pro_savePlaces(pro_Places("Kovai Kondattam Amusement Park Pvt", "2/347, Siruvani Main Rd, Durga nagar, Kalampalayam, Coimbatore, Tamil Nadu 641010", "amuzement park", 41));
            await App.ent_Database.pro_savePlaces(pro_Places("Vivekananda Rock Memorial", "Kanyakumari, Tamil Nadu 629702", "Historic place", 42)); //10
            await App.ent_Database.pro_savePlaces(pro_Places("Kanyakumari beach", "Vavaturai Beach Rd, Kanyakumari, Tamil Nadu", "Beach", 42));
            await App.ent_Database.pro_savePlaces(pro_Places("Vellore Fort", "Balaji Nagar, Vellore, Tamil Nadu 632004", "Fort", 43));
            await App.ent_Database.pro_savePlaces(pro_Places("Jalakanteswarar Temple, Vellore", "Balaji Nagar, Vellore, Tamil Nadu 632004", "Temple", 43)); //62
            await App.ent_Database.pro_savePlaces(pro_Places("Anantapur Museum", "10, Pasaluru - Upparapalli - Anantapur, Adimurthy Nagar, Gulzarpet, Anantapur, Andhra Pradesh 515001", "Museum", 35));
            await App.ent_Database.pro_savePlaces(pro_Places("Sri Chowdeshwari Temple", "Tadipatri Rd, Old Town, Anantapur, Andhra Pradesh 515005", "Temple", 35));
            await App.ent_Database.pro_savePlaces(pro_Places("Chittoor Cliff", "Banglore-Tirupathi Highway Road, Patnam, Andhra Pradesh 517131", "Historic place", 36));
            await App.ent_Database.pro_savePlaces(pro_Places("Dear Park", "Forest Road, Chittoor, Andhra Pradesh 517001", "Park", 36));
            await App.ent_Database.pro_savePlaces(pro_Places("Godavari River Sangamam", "Antarvedi Rd, Antervedi Pallipalem, Andhra Pradesh 533252", "River park", 37));
            await App.ent_Database.pro_savePlaces(pro_Places("pinjari konda water falls", "painjari konda, Duppalapalem, Andhra Pradesh 533428", "WaterFalls", 37));
            await App.ent_Database.pro_savePlaces(pro_Places("Manzhumiya Park", "near N.T.R, Kadapa Rd, Shastri Nagar, Ravindra Nagar, Kadapa, Andhra Pradesh 516001", "Park", 38)); //10
            await App.ent_Database.pro_savePlaces(pro_Places("Kadapa Clock Tower", "One Town Police Station, Ganagapeta, Kadapa, Andhra Pradesh 516001", "Clock tower", 38)); //70
            await App.ent_Database.pro_savePlaces(pro_Places("Satyanarayana Swamy Temple", "Dasnapur, Adilabad(U), Telangana 504001", "Temple", 44));
            await App.ent_Database.pro_savePlaces(pro_Places("Durgadevi Temple", "Durganagar, Khoja Colony, Adilabad(U), Telangana 504001", "Temple", 44));
            await App.ent_Database.pro_savePlaces(pro_Places("Bogatha Waterfall", "chekupelli, Vajedu Road, Chekupalli Rd, Koyaveerapuram G, Telangana 507136", "Waterfall", 45));
            await App.ent_Database.pro_savePlaces(pro_Places("Sri Seetha Ramachandra Swamy Devasthanam", "Paladugu, Telangana 508111", "Temple", 45));
            await App.ent_Database.pro_savePlaces(pro_Places("Nehru Zoological Park", "NH 44, Bahadurpura, Hyderabad, Telangana 500064", "Park", 46));
            await App.ent_Database.pro_savePlaces(pro_Places("Sanjeevaiah Park", "Hussain Sagar, Khairtabad, Hyderabad, Telangana 500003", "Park", 46));
            await App.ent_Database.pro_savePlaces(pro_Places("Sri Amma Bhagvan Temple Jangaon", "Jyothi Nagar, Jangaon, Telangana 506167", "Temple", 47));
            await App.ent_Database.pro_savePlaces(pro_Places("Childrens Park", "Ambedkar Nagar, Jangaon, Telangana 506167", "Park", 47)); //10
            await App.ent_Database.pro_savePlaces(pro_Places("Bhupalpally forest area", "Bhupalpally, Telangana 506169", "Park", 48));
            await App.ent_Database.pro_savePlaces(pro_Places("Seethampeta water falls", "Ippalapalle, Telangana 505184", "Waterfall", 48)); //2

        }
        private tblPlaces pro_Places(string a_Name, string a_Address, string a_Type, int a_District)
        {
            tblPlaces tblPlaces = new tblPlaces()
            {
                fldAddress = a_Address,
                fldName = a_Name,
                fldDistrictID = a_District,
                fldType = a_Type,
            };
            return tblPlaces;
        }
        private async void pro_ReloadPackages()
        {
            p_packages = await App.ent_Database.pro_getPackage();
            if (p_packages.Count == 0)
            {
                pro_AddPackages();
            }
        }
        private async void pro_AddPackages()
        {
            await App.ent_Database.pro_savePackage(pro_Package(1, 5000.0, 500.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(2, 7000.0, 900.0, 3, 18));
            await App.ent_Database.pro_savePackage(pro_Package(3, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(4, 2000.0, 100.0, 2, 18));
            await App.ent_Database.pro_savePackage(pro_Package(5, 3000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(6, 1000.0, 300.0, 2, 18));
            await App.ent_Database.pro_savePackage(pro_Package(7, 1000.0, 300.0, 3, 8));
            await App.ent_Database.pro_savePackage(pro_Package(8, 2000.0, 300.0, 4, 18));
            await App.ent_Database.pro_savePackage(pro_Package(9, 3000.0, 300.0, 2, 18));
            await App.ent_Database.pro_savePackage(pro_Package(10, 1000.0, 200.0, 1, 18));
            await App.ent_Database.pro_savePackage(pro_Package(11, 2000.0, 100.0, 2, 8));
            await App.ent_Database.pro_savePackage(pro_Package(12, 3000.0, 300.0, 3, 18));
            await App.ent_Database.pro_savePackage(pro_Package(13, 1000.0, 200.0, 2, 8));
            await App.ent_Database.pro_savePackage(pro_Package(14, 2000.0, 100.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(15, 3000.0, 300.0, 4, 18));
            await App.ent_Database.pro_savePackage(pro_Package(16, 1000.0, 200.0, 3, 18));
            await App.ent_Database.pro_savePackage(pro_Package(17, 2000.0, 100.0, 2, 18));
            await App.ent_Database.pro_savePackage(pro_Package(18, 3000.0, 300.0, 3, 18));
            await App.ent_Database.pro_savePackage(pro_Package(19, 1000.0, 200.0, 4, 18));
            await App.ent_Database.pro_savePackage(pro_Package(20, 2000.0, 100.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(21, 3000.0, 200.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(22, 1000.0, 100.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(23, 2000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(24, 3000.0, 200.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(25, 1000.0, 100.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(26, 2000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(27, 3000.0, 200.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(28, 1000.0, 100.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(29, 2000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(30, 3000.0, 200.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(31, 4000.0, 100.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(32, 1000.0, 200.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(33, 2000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(34, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(35, 4000.0, 300.0, 5, 18));

            await App.ent_Database.pro_savePackage(pro_Package(36, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(37, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(38, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(39, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(40, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(41, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(42, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(43, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(44, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(45, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(46, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(47, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(48, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(49, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(50, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(51, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(52, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(53, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(54, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(55, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(56, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(57, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(58, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(59, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(60, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(61, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(62, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(63, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(64, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(65, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(66, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(67, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(68, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(69, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(70, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(71, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(72, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(73, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(74, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(75, 4000.0, 300.0, 5, 18)); 
            await App.ent_Database.pro_savePackage(pro_Package(76, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(77, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(78, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(79, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(80, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(81, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(82, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(83, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(84, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(85, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(86, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(87, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(88, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(89, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(90, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(91, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(92, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(93, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(94, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(95, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(96, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(97, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(98, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(99, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(100, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(101, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(102, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(103, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(104, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(105, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(106, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(107, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(108, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(109, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(110, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(111, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(112, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(113, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(114, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(115, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(116, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(117, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(118, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(119, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(120, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(121, 4000.0, 300.0, 5, 18));
            await App.ent_Database.pro_savePackage(pro_Package(122, 4000.0, 300.0, 5, 18));




        }
        private tblPackage pro_Package(int a_placeid, double a_pkamt, double a_disc, double a_serv, double a_tax)
        {
            tblPackage tblPackage = new tblPackage()
            {
                fldDiscount = a_disc,
                fldPackageAmount = a_pkamt,
                fldPlaceId = a_placeid,
                fldServiceCharge = a_serv,
                fldTotalTaxes = a_tax
            };
            return tblPackage;
        }
        private async void pro_ReloadDistricts()
        {
            p_Districts = await App.ent_Database.pro_getDistricts();
            if (p_Districts.Count == 0)
            {
                pro_AddDistrict();
            }
        }
        private async void pro_AddDistrict()
        {
            await App.ent_Database.pro_saveDistrict(pro_District(11, "Bagalkot")); //1
            await App.ent_Database.pro_saveDistrict(pro_District(11, "Ballari")); //2
            await App.ent_Database.pro_saveDistrict(pro_District(11, "Belgavi")); //3
            await App.ent_Database.pro_saveDistrict(pro_District(11, "Bengaluru (Bangalore) Rural")); //4
            await App.ent_Database.pro_saveDistrict(pro_District(11, "Bengaluru (Bangalore) Urban")); //5
            await App.ent_Database.pro_saveDistrict(pro_District(11, "Chamarajanagar")); //6
            await App.ent_Database.pro_saveDistrict(pro_District(11, "Chikballapur")); //7
            await App.ent_Database.pro_saveDistrict(pro_District(11, "Chikkamagaluru")); //8
            await App.ent_Database.pro_saveDistrict(pro_District(11, "Chitradurga")); //9
            await App.ent_Database.pro_saveDistrict(pro_District(11, "Dakshina Kannada")); //10
            await App.ent_Database.pro_saveDistrict(pro_District(11, "Davangere")); //11
            await App.ent_Database.pro_saveDistrict(pro_District(11, "Dharwad")); //12
            await App.ent_Database.pro_saveDistrict(pro_District(11, "Gadag")); //13
            await App.ent_Database.pro_saveDistrict(pro_District(11, "Hassan")); //14
            await App.ent_Database.pro_saveDistrict(pro_District(11, "Kalaburagi"));//15
            await App.ent_Database.pro_saveDistrict(pro_District(11, "Kodagu")); //16
            await App.ent_Database.pro_saveDistrict(pro_District(11, "Kolar")); //17
            await App.ent_Database.pro_saveDistrict(pro_District(11, "Koppal")); //18
            await App.ent_Database.pro_saveDistrict(pro_District(11, "Mandya")); //19
            await App.ent_Database.pro_saveDistrict(pro_District(11, "Mysuru")); //20
            await App.ent_Database.pro_saveDistrict(pro_District(11, "Raichur")); //21
            await App.ent_Database.pro_saveDistrict(pro_District(11, "Ramanagara")); //22
            await App.ent_Database.pro_saveDistrict(pro_District(11, "Shivamogga")); //23
            await App.ent_Database.pro_saveDistrict(pro_District(11, "Tumakuru")); //24
            await App.ent_Database.pro_saveDistrict(pro_District(11, "Udupi")); //25
            await App.ent_Database.pro_saveDistrict(pro_District(11, "Uttara Kannada")); //26
            await App.ent_Database.pro_saveDistrict(pro_District(11, "Vijayapura ")); //27
            await App.ent_Database.pro_saveDistrict(pro_District(11, "Yadgir")); //28
            //kerala
            await App.ent_Database.pro_saveDistrict(pro_District(12, "Kannur")); //29
            await App.ent_Database.pro_saveDistrict(pro_District(12, "Kasaragod")); //30
            await App.ent_Database.pro_saveDistrict(pro_District(12, "Kollam")); //31
            await App.ent_Database.pro_saveDistrict(pro_District(12, "Kottayam")); //32
            await App.ent_Database.pro_saveDistrict(pro_District(12, "Kozhikode")); //33
            await App.ent_Database.pro_saveDistrict(pro_District(12, "Palakkad")); //34
            //AP
            await App.ent_Database.pro_saveDistrict(pro_District(1, "Anantapur")); //35
            await App.ent_Database.pro_saveDistrict(pro_District(1, "Chittoor")); //36
            await App.ent_Database.pro_saveDistrict(pro_District(1, "East Godavari")); //37
            await App.ent_Database.pro_saveDistrict(pro_District(1, "Kadapa")); //38
            //TN
            await App.ent_Database.pro_saveDistrict(pro_District(23, "Ariyalur")); //39
            await App.ent_Database.pro_saveDistrict(pro_District(23, "Chennai")); //40
            await App.ent_Database.pro_saveDistrict(pro_District(23, "Coimbatore")); //41
            await App.ent_Database.pro_saveDistrict(pro_District(23, "Kanyakumari")); //42
            await App.ent_Database.pro_saveDistrict(pro_District(23, "Vellore")); //43
            //telangana
            await App.ent_Database.pro_saveDistrict(pro_District(24, "Adilabad")); //44
            await App.ent_Database.pro_saveDistrict(pro_District(24, "Bhadradri Kothagudem"));//45
            await App.ent_Database.pro_saveDistrict(pro_District(24, "Hyderabad"));//46
            await App.ent_Database.pro_saveDistrict(pro_District(24, "Jangaon")); //47
            await App.ent_Database.pro_saveDistrict(pro_District(24, "Jayashankar Bhupalapally")); //48


        }
        private tblDistricts pro_District(int a_StateId, String a_District)
        {
            tblDistricts tblDistricts = new tblDistricts()
            {
                fldStateID = a_StateId,
                fldDistrict = a_District
            };
            return tblDistricts;
        }
        private async void pro_ReloadRestaurants()
        {
            p_restaurants = await App.ent_Database.pro_getRestaurants(); ;
            if (p_restaurants.Count == 0)
            {
                pro_AddRestaurants();
            }
        }
        private async void pro_AddRestaurants()
        {
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Yauatcha", "Mahatma Gandhi Rd, Someshwarpura", "4Star", 4));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" SANTRIPTI", "Beratena Agrahara Lav Kush Nagar", "3Star", 4));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Cube Stop", "MavalliBengaluru, Karnataka 560004", "4Star", 4));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Royal Square", "Mavalli, Bengaluru, Karnataka 560004", "5Star", 4));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Le Cirque Signature", "Lal Bagh Main Rd, Mavalli, Bengaluru, Karnataka 560004", "3Star", 4));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Bugle Rock Park", "Bull Temple Rd, Basavanagudi, Bengaluru, Karnataka 560019", "5Star", 4));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" Misu Trade Tower", "Kasturba Road, Behind High Court of Karnataka Ambedkar Veedhi, Sampangi Rama Nagara, Bengaluru, Karnataka 560001", "4Star", 4));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Franco Italian Restaurant", "Field Marshal Cariappa Rd, Shanthala Nagar, Ashok Nagar, Bengaluru, Karnataka 560001", "5Star", 4));
            //1
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Yauatcha", "Mahatma Gandhi Rd, Someshwarpura", "4Star", 1));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" SANTRIPTI", "Beratena Agrahara Lav Kush Nagar", "3Star", 1));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Cube Stop", "MavalliBengaluru", "4Star", 1));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Royal Square", "Mavalli", "5Star", 1));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Le Cirque Signature", "Lal Bagh Main Rd, Mavalli", "3Star", 1));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Bugle Rock Park", "Bull Temple Rd, Basavanagudi", "5Star", 1));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" Misu Trade Tower", "Kasturba Road, Behind High Court Ambedkar Veedhi,", "4Star", 1));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Franco Italian Restaurant", "Field Marshal Cariappa Rd, Shanthala Nagar, Ashok Nagar", "5Star", 1));
            //2
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Yauatcha", "Mahatma Gandhi Rd, Someshwarpura", "4Star", 2));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" SANTRIPTI", "Beratena Agrahara Lav Kush Nagar", "3Star", 2));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Cube Stop", "MavalliBengaluru", "4Star", 2));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Royal Square", "Mavalli", "5Star", 2));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Le Cirque Signature", "Lal Bagh Main Rd, Mavalli", "3Star", 2));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Bugle Rock Park", "Bull Temple Rd, Basavanagudi", "5Star", 2));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" Misu Trade Tower", "Kasturba Road, Behind High Court Ambedkar Veedhi,", "4Star", 2));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Franco Italian Restaurant", "Field Marshal Cariappa Rd, Shanthala Nagar, Ashok Nagar", "5Star", 2));

            //3
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Yauatcha", "Mahatma Gandhi Rd, Someshwarpura", "4Star", 3));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" SANTRIPTI", "Beratena Agrahara Lav Kush Nagar", "3Star", 3));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Cube Stop", "MavalliBengaluru", "4Star", 3));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Royal Square", "Mavalli", "5Star", 3));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Le Cirque Signature", "Lal Bagh Main Rd, Mavalli", "3Star", 3));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Bugle Rock Park", "Bull Temple Rd, Basavanagudi", "5Star", 3));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" Misu Trade Tower", "Kasturba Road, Behind High Court Ambedkar Veedhi,", "4Star", 3));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Franco Italian Restaurant", "Field Marshal Cariappa Rd, Shanthala Nagar, Ashok Nagar", "5Star", 3));

            //4
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Yauatcha", "Mahatma Gandhi Rd, Someshwarpura", "4Star", 5));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" SANTRIPTI", "Beratena Agrahara Lav Kush Nagar", "3Star", 5));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Cube Stop", "MavalliBengaluru", "4Star", 5));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Royal Square", "Mavalli", "5Star", 5));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Le Cirque Signature", "Lal Bagh Main Rd, Mavalli", "3Star", 5));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Bugle Rock Park", "Bull Temple Rd, Basavanagudi", "5Star", 5));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" Misu Trade Tower", "Kasturba Road, Behind High Court Ambedkar Veedhi,", "4Star", 5));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Franco Italian Restaurant", "Field Marshal Cariappa Rd, Shanthala Nagar, Ashok Nagar", "5Star", 5));

            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Yauatcha", "Mahatma Gandhi Rd, Someshwarpura", "4Star", 6));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" SANTRIPTI", "Beratena Agrahara Lav Kush Nagar", "3Star", 6));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Cube Stop", "MavalliBengaluru", "4Star", 6));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Royal Square", "Mavalli", "5Star", 6));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Le Cirque Signature", "Lal Bagh Main Rd, Mavalli", "3Star", 6));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Bugle Rock Park", "Bull Temple Rd, Basavanagudi", "5Star", 6));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" Misu Trade Tower", "Kasturba Road, Behind High Court Ambedkar Veedhi,", "4Star", 6));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Franco Italian Restaurant", "Field Marshal Cariappa Rd, Shanthala Nagar, Ashok Nagar", "5Star", 6));

            //7
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Yauatcha", "Mahatma Gandhi Rd, Someshwarpura", "4Star", 7));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" SANTRIPTI", "Beratena Agrahara Lav Kush Nagar", "3Star", 7));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Cube Stop", "MavalliBengaluru", "4Star", 7));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Royal Square", "Mavalli", "5Star", 7));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Le Cirque Signature", "Lal Bagh Main Rd, Mavalli", "3Star", 7));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Bugle Rock Park", "Bull Temple Rd, Basavanagudi", "5Star", 7));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" Misu Trade Tower", "Kasturba Road, Behind High Court Ambedkar Veedhi,", "4Star", 7));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Franco Italian Restaurant", "Field Marshal Cariappa Rd, Shanthala Nagar, Ashok Nagar", "5Star", 7));
            //8
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Yauatcha", "Mahatma Gandhi Rd, Someshwarpura", "4Star", 8));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" SANTRIPTI", "Beratena Agrahara Lav Kush Nagar", "3Star", 8));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Cube Stop", "MavalliBengaluru", "4Star", 8));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Royal Square", "Mavalli", "5Star", 8));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Le Cirque Signature", "Lal Bagh Main Rd, Mavalli", "3Star", 8));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Bugle Rock Park", "Bull Temple Rd, Basavanagudi", "5Star", 8));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" Misu Trade Tower", "Kasturba Road, Behind High Court Ambedkar Veedhi,", "4Star", 8));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Franco Italian Restaurant", "Field Marshal Cariappa Rd, Shanthala Nagar, Ashok Nagar", "5Star", 8));
            //9
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Yauatcha", "Mahatma Gandhi Rd, Someshwarpura", "4Star", 9));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" SANTRIPTI", "Beratena Agrahara Lav Kush Nagar", "3Star", 9));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Cube Stop", "MavalliBengaluru", "4Star", 9));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Royal Square", "Mavalli", "5Star", 9));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Le Cirque Signature", "Lal Bagh Main Rd, Mavalli", "3Star", 9));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Bugle Rock Park", "Bull Temple Rd, Basavanagudi", "5Star", 9));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" Misu Trade Tower", "Kasturba Road, Behind High Court Ambedkar Veedhi,", "4Star", 9));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Franco Italian Restaurant", "Field Marshal Cariappa Rd, Shanthala Nagar, Ashok Nagar", "5Star", 9));
            //10
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Yauatcha", "Mahatma Gandhi Rd, Someshwarpura", "4Star", 10));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" SANTRIPTI", "Beratena Agrahara Lav Kush Nagar", "3Star", 10));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Cube Stop", "MavalliBengaluru", "4Star", 10));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Royal Square", "Mavalli", "5Star", 10));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Le Cirque Signature", "Lal Bagh Main Rd, Mavalli", "3Star", 10));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Bugle Rock Park", "Bull Temple Rd, Basavanagudi", "5Star", 10));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" Misu Trade Tower", "Kasturba Road, Behind High Court Ambedkar Veedhi,", "4Star", 10));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Franco Italian Restaurant", "Field Marshal Cariappa Rd, Shanthala Nagar, Ashok Nagar", "5Star", 10));
            //11
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Yauatcha", "Mahatma Gandhi Rd, Someshwarpura", "4Star", 12));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" SANTRIPTI", "Beratena Agrahara Lav Kush Nagar", "3Star", 12));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Cube Stop", "MavalliBengaluru", "4Star", 12));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Royal Square", "Mavalli", "5Star", 12));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Le Cirque Signature", "Lal Bagh Main Rd, Mavalli", "3Star", 12));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Bugle Rock Park", "Bull Temple Rd, Basavanagudi", "5Star", 12));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" Misu Trade Tower", "Kasturba Road, Behind High Court Ambedkar Veedhi,", "4Star", 12));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Franco Italian Restaurant", "Field Marshal Cariappa Rd, Shanthala Nagar, Ashok Nagar", "5Star", 12));
            //12
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Yauatcha", "Mahatma Gandhi Rd, Someshwarpura", "4Star", 11));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" SANTRIPTI", "Beratena Agrahara Lav Kush Nagar", "3Star", 11));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Cube Stop", "MavalliBengaluru", "4Star", 11));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Royal Square", "Mavalli", "5Star", 11));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Le Cirque Signature", "Lal Bagh Main Rd, Mavalli", "3Star", 11));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Bugle Rock Park", "Bull Temple Rd, Basavanagudi", "5Star", 11));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" Misu Trade Tower", "Kasturba Road, Behind High Court Ambedkar Veedhi,", "4Star", 11));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Franco Italian Restaurant", "Field Marshal Cariappa Rd, Shanthala Nagar, Ashok Nagar", "5Star", 11));
            //13
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Yauatcha", "Mahatma Gandhi Rd, Someshwarpura", "4Star", 13));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" SANTRIPTI", "Beratena Agrahara Lav Kush Nagar", "3Star", 14));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Cube Stop", "MavalliBengaluru", "4Star", 14));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Royal Square", "Mavalli", "5Star", 14));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Le Cirque Signature", "Lal Bagh Main Rd, Mavalli", "3Star", 14));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Bugle Rock Park", "Bull Temple Rd, Basavanagudi", "5Star", 14));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" Misu Trade Tower", "Kasturba Road, Behind High Court Ambedkar Veedhi,", "4Star", 14));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Franco Italian Restaurant", "Field Marshal Cariappa Rd, Shanthala Nagar, Ashok Nagar", "5Star", 14));
            //15
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Yauatcha", "Mahatma Gandhi Rd, Someshwarpura", "4Star", 15));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" SANTRIPTI", "Beratena Agrahara Lav Kush Nagar", "3Star", 15));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Cube Stop", "MavalliBengaluru", "4Star", 15));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Royal Square", "Mavalli", "5Star", 15));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Le Cirque Signature", "Lal Bagh Main Rd, Mavalli", "3Star", 15));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Bugle Rock Park", "Bull Temple Rd, Basavanagudi", "5Star", 15));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" Misu Trade Tower", "Kasturba Road, Behind High Court Ambedkar Veedhi,", "4Star", 15));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Franco Italian Restaurant", "Field Marshal Cariappa Rd, Shanthala Nagar, Ashok Nagar", "5Star", 15));
            //16
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Yauatcha", "Mahatma Gandhi Rd, Someshwarpura", "4Star", 17));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" SANTRIPTI", "Beratena Agrahara Lav Kush Nagar", "3Star", 17));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Cube Stop", "MavalliBengaluru", "4Star", 17));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Royal Square", "Mavalli", "5Star", 17));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Le Cirque Signature", "Lal Bagh Main Rd, Mavalli", "3Star", 17));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Bugle Rock Park", "Bull Temple Rd, Basavanagudi", "5Star", 17));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" Misu Trade Tower", "Kasturba Road, Behind High Court Ambedkar Veedhi,", "4Star", 17));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Franco Italian Restaurant", "Field Marshal Cariappa Rd, Shanthala Nagar, Ashok Nagar", "5Star", 17));
            //17
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Yauatcha", "Mahatma Gandhi Rd, Someshwarpura", "4Star", 16));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" SANTRIPTI", "Beratena Agrahara Lav Kush Nagar", "3Star", 16));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Cube Stop", "MavalliBengaluru", "4Star", 16));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Royal Square", "Mavalli", "5Star", 16));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Le Cirque Signature", "Lal Bagh Main Rd, Mavalli", "3Star", 16));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Bugle Rock Park", "Bull Temple Rd, Basavanagudi", "5Star", 16));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" Misu Trade Tower", "Kasturba Road, Behind High Court Ambedkar Veedhi,", "4Star", 16));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Franco Italian Restaurant", "Field Marshal Cariappa Rd, Shanthala Nagar, Ashok Nagar", "5Star", 16));
            //18
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Yauatcha", "Mahatma Gandhi Rd, Someshwarpura", "4Star", 18));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" SANTRIPTI", "Beratena Agrahara Lav Kush Nagar", "3Star", 18));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Cube Stop", "MavalliBengaluru", "4Star", 18));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Royal Square", "Mavalli", "5Star", 18));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Le Cirque Signature", "Lal Bagh Main Rd, Mavalli", "3Star", 18));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Bugle Rock Park", "Bull Temple Rd, Basavanagudi", "5Star", 18));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" Misu Trade Tower", "Kasturba Road, Behind High Court Ambedkar Veedhi,", "4Star", 18));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Franco Italian Restaurant", "Field Marshal Cariappa Rd, Shanthala Nagar, Ashok Nagar", "5Star", 18));
            //19
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Yauatcha", "Mahatma Gandhi Rd, Someshwarpura", "4Star", 19));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" SANTRIPTI", "Beratena Agrahara Lav Kush Nagar", "3Star", 19));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Cube Stop", "MavalliBengaluru", "4Star", 19));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Royal Square", "Mavalli", "5Star", 19));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Le Cirque Signature", "Lal Bagh Main Rd, Mavalli", "3Star", 19));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Bugle Rock Park", "Bull Temple Rd, Basavanagudi", "5Star", 19));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" Misu Trade Tower", "Kasturba Road, Behind High Court Ambedkar Veedhi,", "4Star", 19));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Franco Italian Restaurant", "Field Marshal Cariappa Rd, Shanthala Nagar, Ashok Nagar", "5Star", 19));
            //20
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Yauatcha", "Mahatma Gandhi Rd, Someshwarpura", "4Star", 20));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" SANTRIPTI", "Beratena Agrahara Lav Kush Nagar", "3Star", 20));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Cube Stop", "MavalliBengaluru", "4Star", 20));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Royal Square", "Mavalli", "5Star", 20));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Le Cirque Signature", "Lal Bagh Main Rd, Mavalli", "3Star", 20));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Bugle Rock Park", "Bull Temple Rd, Basavanagudi", "5Star", 20));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" Misu Trade Tower", "Kasturba Road, Behind High Court Ambedkar Veedhi,", "4Star",20 ));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Franco Italian Restaurant", "Field Marshal Cariappa Rd, Shanthala Nagar, Ashok Nagar", "5Star", 20));
            //21
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Yauatcha", "Mahatma Gandhi Rd, Someshwarpura", "4Star", 21));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" SANTRIPTI", "Beratena Agrahara Lav Kush Nagar", "3Star", 21));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Cube Stop", "MavalliBengaluru", "4Star", 21));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Royal Square", "Mavalli", "5Star", 21));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Le Cirque Signature", "Lal Bagh Main Rd, Mavalli", "3Star", 21));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Bugle Rock Park", "Bull Temple Rd, Basavanagudi", "5Star", 21));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" Misu Trade Tower", "Kasturba Road, Behind High Court Ambedkar Veedhi,", "4Star", 21));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Franco Italian Restaurant", "Field Marshal Cariappa Rd, Shanthala Nagar, Ashok Nagar", "5Star", 21));
            //22
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Yauatcha", "Mahatma Gandhi Rd, Someshwarpura", "4Star", 22));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" SANTRIPTI", "Beratena Agrahara Lav Kush Nagar", "3Star", 22));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Cube Stop", "MavalliBengaluru", "4Star", 22));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Royal Square", "Mavalli", "5Star", 22));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Le Cirque Signature", "Lal Bagh Main Rd, Mavalli", "3Star", 22));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Bugle Rock Park", "Bull Temple Rd, Basavanagudi", "5Star", 22));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" Misu Trade Tower", "Kasturba Road, Behind High Court Ambedkar Veedhi,", "4Star", 22));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Franco Italian Restaurant", "Field Marshal Cariappa Rd, Shanthala Nagar, Ashok Nagar", "5Star", 22));
            //23
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Yauatcha", "Mahatma Gandhi Rd, Someshwarpura", "4Star", 23));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" SANTRIPTI", "Beratena Agrahara Lav Kush Nagar", "3Star", 23));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Cube Stop", "MavalliBengaluru", "4Star", 23));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Royal Square", "Mavalli", "5Star", 23));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Le Cirque Signature", "Lal Bagh Main Rd, Mavalli", "3Star", 23));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Bugle Rock Park", "Bull Temple Rd, Basavanagudi", "5Star", 23));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" Misu Trade Tower", "Kasturba Road, Behind High Court Ambedkar Veedhi,", "4Star", 23));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Franco Italian Restaurant", "Field Marshal Cariappa Rd, Shanthala Nagar, Ashok Nagar", "5Star", 23));
            //24
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Yauatcha", "Mahatma Gandhi Rd, Someshwarpura", "4Star", 24));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" SANTRIPTI", "Beratena Agrahara Lav Kush Nagar", "3Star", 24));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Cube Stop", "MavalliBengaluru", "4Star", 24));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Royal Square", "Mavalli", "5Star", 24));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Le Cirque Signature", "Lal Bagh Main Rd, Mavalli", "3Star", 24));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Bugle Rock Park", "Bull Temple Rd, Basavanagudi", "5Star", 24));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" Misu Trade Tower", "Kasturba Road, Behind High Court Ambedkar Veedhi,", "4Star", 24));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Franco Italian Restaurant", "Field Marshal Cariappa Rd, Shanthala Nagar, Ashok Nagar", "5Star", 24));
            //25
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Yauatcha", "Mahatma Gandhi Rd, Someshwarpura", "4Star", 25));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" SANTRIPTI", "Beratena Agrahara Lav Kush Nagar", "3Star", 25));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Cube Stop", "MavalliBengaluru", "4Star", 25));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Royal Square", "Mavalli", "5Star", 25));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Le Cirque Signature", "Lal Bagh Main Rd, Mavalli", "3Star", 25));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Bugle Rock Park", "Bull Temple Rd, Basavanagudi", "5Star", 25));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" Misu Trade Tower", "Kasturba Road, Behind High Court Ambedkar Veedhi,", "4Star", 25));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Franco Italian Restaurant", "Field Marshal Cariappa Rd, Shanthala Nagar, Ashok Nagar", "5Star", 25));
            //26
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Yauatcha", "Mahatma Gandhi Rd, Someshwarpura", "4Star", 26));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" SANTRIPTI", "Beratena Agrahara Lav Kush Nagar", "3Star", 26));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Cube Stop", "MavalliBengaluru", "4Star", 26));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Royal Square", "Mavalli", "5Star", 26));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Le Cirque Signature", "Lal Bagh Main Rd, Mavalli", "3Star", 26));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Bugle Rock Park", "Bull Temple Rd, Basavanagudi", "5Star", 26));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" Misu Trade Tower", "Kasturba Road, Behind High Court Ambedkar Veedhi,", "4Star", 26));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Franco Italian Restaurant", "Field Marshal Cariappa Rd, Shanthala Nagar, Ashok Nagar", "5Star", 26));
            //27
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Yauatcha", "Mahatma Gandhi Rd, Someshwarpura", "4Star", 27));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" SANTRIPTI", "Beratena Agrahara Lav Kush Nagar", "3Star", 27));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Cube Stop", "MavalliBengaluru", "4Star", 27));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Royal Square", "Mavalli", "5Star", 27));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Le Cirque Signature", "Lal Bagh Main Rd, Mavalli", "3Star", 27));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Bugle Rock Park", "Bull Temple Rd, Basavanagudi", "5Star", 27));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" Misu Trade Tower", "Kasturba Road, Behind High Court Ambedkar Veedhi,", "4Star", 27));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Franco Italian Restaurant", "Field Marshal Cariappa Rd, Shanthala Nagar, Ashok Nagar", "5Star", 27));
            //29
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Yauatcha", "Mahatma Gandhi Rd, Someshwarpura", "4Star", 29));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" SANTRIPTI", "Beratena Agrahara Lav Kush Nagar", "3Star", 29));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Cube Stop", "MavalliBengaluru", "4Star", 29));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Royal Square", "Mavalli", "5Star", 29));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Le Cirque Signature", "Lal Bagh Main Rd, Mavalli", "3Star", 29));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Bugle Rock Park", "Bull Temple Rd, Basavanagudi", "5Star", 29));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" Misu Trade Tower", "Kasturba Road, Behind High Court Ambedkar Veedhi,", "4Star", 29));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Franco Italian Restaurant", "Field Marshal Cariappa Rd, Shanthala Nagar, Ashok Nagar", "5Star", 29));
            //35
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Yauatcha", "Mahatma Gandhi Rd, Someshwarpura", "4Star", 35));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" SANTRIPTI", "Beratena Agrahara Lav Kush Nagar", "3Star", 35));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Cube Stop", "MavalliBengaluru", "4Star", 35));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Royal Square", "Mavalli", "5Star", 35));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Le Cirque Signature", "Lal Bagh Main Rd, Mavalli", "3Star", 39));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Bugle Rock Park", "Bull Temple Rd, Basavanagudi", "5Star", 39));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" Misu Trade Tower", "Kasturba Road, Behind High Court Ambedkar Veedhi,", "4Star", 39));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Franco Italian Restaurant", "Field Marshal Cariappa Rd, Shanthala Nagar, Ashok Nagar", "5Star", 39));
            //44
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Yauatcha", "Mahatma Gandhi Rd, Someshwarpura", "4Star", 44));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" SANTRIPTI", "Beratena Agrahara Lav Kush Nagar", "3Star", 44));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Cube Stop", "MavalliBengaluru", "4Star", 44));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Royal Square", "Mavalli", "5Star", 44));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Le Cirque Signature", "Lal Bagh Main Rd, Mavalli", "3Star", 44));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Bugle Rock Park", "Bull Temple Rd, Basavanagudi", "5Star", 44));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants(" Misu Trade Tower", "Kasturba Road, Behind High Court Ambedkar Veedhi,", "4Star", 44));
            await App.ent_Database.pro_saveRestaurants(pro_Restaurants("Franco Italian Restaurant", "Field Marshal Cariappa Rd, Shanthala Nagar, Ashok Nagar", "5Star", 44));

        }
        private tblRestaurants pro_Restaurants(string a_Name, string a_Address, string a_Type, int a_District)
        {
            tblRestaurants tblRestaurants = new tblRestaurants()
            {
                fldAddress = a_Address,
                fldName = a_Name,
                fldDistrictID = a_District,
                fldType = a_Type,
            };
            return tblRestaurants;
        }
    }
}
