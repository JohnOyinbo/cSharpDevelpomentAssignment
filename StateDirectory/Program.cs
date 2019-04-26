using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 37;
            //Console.WriteLine($"{i}. {states[i-1]}");
            Console.WriteLine(northCentral.Length + northEast.Length + northWest.Length + southEast.Length + southSouth.Length + southWest.Length);
            Console.WriteLine(benue[1]);

            Console.WriteLine("welcome, there are 6 geo political zones in nigeria \n press 1 to display them or press 2 to display the states");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a==1)
            {
                for (int i=0; i < geoPoliticalZones.Length; i++)
                {
                    Console.WriteLine($"{i+1}. {geoPoliticalZones[i]}");
                }
                Console.ReadLine();

                Console.WriteLine("select a Geo Political Zone");
                int b = Convert.ToInt32(Console.ReadLine());

                var x = geoPoliticalZones2[b - 1] ;
                for (int i = 0; i < x.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {x[i]}");
                }
                Console.ReadLine();

            }
            else if (a==2)
            {
                for (int i = 0; i < states.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {states[i]}");
                }
            }




            Console.ReadLine();
        }
        public static string[] geoPoliticalZones = {"North Central", "North East", "North West", "South East", "South South", "South West"};
        public static string[] states = { "Abia", "Adamawa", "Akwa Ibom", "Anambra", "Bauchi", "Bayelsa", "Benue", "Borno", "Cross River",
                                        "Delta", "Ebonyi", "Edo", "Ekiti", "Enugu", "Gombe", "Imo", "Jigawa", "Kaduna", "Kano", "Katsina",
                                        "Kebbi", "Kogi", "Kwara", "Lagos", "Nasarawa", "Niger", "Ogun", "Ondo", "Osun", "Oyo", "Plateau",
                                            "Rivers", "Sokoto", "Taraba", "Yobe", "Zamfara", "Federal Capital Territory" };
       // NORTH CENTRAL 
       
        public static string[] northCentral = { "Benue", "Kogi", "Kwara", "Nasarawa", "Niger", "Plateau", "Federal Capital Territory" };
        public static string[] benue = {"Ado", "Agatu", "Apa", "Buruku", "Gboko","Guma", "Gwer East", "Gwer West",
                                        "Katsina-Ala", "Konshisha","Kwande","Logo","Makurdi","Obi","Ogbadibo","Ohimini",
                                        "Oju","Okpokwu","Otukpo","Tarka","Ukum","Ushongo","Vandeikya",};
        public static string[] kogi = {"Adavi","Ajaokuta","Ankpa","Bassa","Dekina","Ibaji","Idah","Igalamela-Odolu","Ijumu", "Kabba/Bunu",
                                       "Koton Karfe", "Lokoja", "Mopa-Muro", "Ofu", "Ogori/Magongo", "Okehi", "Okene", "Olamaboro", "Omala",
                                        "Yagba East", "Yagba West" };
        public static string[] kwara = {"Asa","Baruten","Edu","Ekiti","Ifelodun","Ilorin East","Ilorin South",
                                        "Ilorin West","Irepodun","Isin","Kaiama","Moro","Offa","Oke Ero","Oyun","Patigi" };
        public static string[] nasarawa = { "Akwanga", "Awe", "Doma", "Karu", "Keana", "Keffi", "Kokona", "Lafia", "Nasarawa", "Nasarawa-Eggon", "Obi", "Toto", "Wamba" };
        public static string[] niger = {"Agaie","Agwara","Bida","Borgu","Bosso","Chanchaga","Edati","Gbako","Gurara","Katcha","Kontagora",
                                        "Lapai","Lavun","Magama","Mariga","Mashegu","Mokwa","Munya","Paikoro","Rafi","Rijau","Shiroro","Suleja","Tafa","Wushishi", };
        public static string[] plateau = {"Barkin Ladi","Bassa","Bokkos","Jos East","Jos North","Jos South","Kanam",
                                        "Kanke","Langtang North","Langtang South","Mangu","Mikang","Pankshin","Qua'an Pan","Riyom","Shendam","Wase"};
        public static string[] fct = { "Abaji", "Abuja Municipal", "Gwagwalada", "Kuje", "Bwari", "Kwali" };
     
       
       //NORTH EAST
        public static string[] northEast = { "Adamawa", "Bauchi", "Borno", "Gombe", "Taraba", "Yobe" };
        public static string[] adamawa = {"Demsa","Fufore","Ganye","Gayuk","Girei","Gombi","Guyuk","Jada","Lamurde","Madagali","Maiha",
                                        "Mayo Belwa","Michika","Mubi North","Mubi South","Numan","Shelleng","Song","Toungo","Yola North","Yola South" };
        public static string[] bauchi = {"Alkaleri","Bauchi","Bogoro","Damban","Darazo","Dass","Gamawa","Ganjuwa","Giade","Itas/Gadau","Jama'are",
                                        "Katagum","Kirfi","Misau","Ningi","Shira","Tafawa Balewa","Toro","Warji","Zaki"};
        public static string[] borno = {"Abadam","Askira/Uba","Bama","Bayo","Biu","Chibok","Damboa","Dikwa","Gubio","Guzamala","Gwoza","Hawul","Jere","Kaga",
                                        "Kala/Balge","Konduga","Kukawa","Kwaya Kusar","Mafa","Magumeri","Maiduguri","Marte","Mobbar","Monguno","Ngala","Nganzai","Shani"};
        public static string[] gombe = { "Akko", "Balanga", "Billiri", "Dukku", "Funakaye", "Gombe", "Kaltungo", "Kumo", "Kwami", "Nafada", "Shongom", "Yamaltu/Deba" };
        public static string[] taraba = { "Ardo Kola","Bali","Donga","Gashaka","Gassol","Ibi","Jalingo","Karim Lamido","Kurmi","Lau","Sardauna","Takum","Ussa","Wukari","Yorro","Zing"};
        public static string[] yobe = {"Bade","Bursari","Damaturu","Fika","Fune","Geidam","Gujba","Gulani","Jakusko","Karasuwa","Machina","Nangere","Potiskum","Tarmuwa","Yusufari"};
      
       //NORTH WEST
        public static string[] northWest = { "Jigawa", "Kaduna", "Kano", "Katsina", "Kebbi", "Sokoto", "Zamfara" };
        public static string[] jigawa = {"Auyo","Babura","Birniwa","Birnin Kudu","Buji","Dutse","Gagarawa","Garki","Gumel","Guri","Gwaram","Gwiwa",
                                        "Hadejia","Jahun","Kafin Hausa","Kaugama","Kazaure","Kiri Kasama","Kiyawa","Maigatari","Malam Madori",
                                        "Miga","Ringim","Roni","Sule Tankarkar","Taura","Yankwashi"};
        public static string[] kaduna = {"Birnin Gwari","Chikun","Giwa","Igabi","Ikara","Jaba","Jema’a","Kachia","Kaduna North","Kaduna South","Kagarko","Kajuru",
                                        "Kaura","Kauru","Kubau","Kudan","Lere","Makarfi","Sabon Gari","Sanga","Soba","Zangon Kataf","Zaria"};
        public static string[] kano = {"Ajingi","Albasu","Bagwai","Bebeji","Bichi","Bunkure","Dala","Dambatta","Dawakin Kudu","Dawakin Tofa","Doguwa",
                                        "Fagge","Gabasawa","Garko","Garun Mallam","Gaya","Gezawa","Gwale","Gwarzo","Kabo","Kano Municipal","Karaye",
                                        "Kibiya","Kiru","Kumbotso","Kunchi","Kura","Madobi","Makoda","Minjibir","Nasarawa","Rano","Rimin Gado","Rogo",
                                        "Shanono","Sumaila","Takai","Tarauni","Tofa","Tsanyawa","Tudun Wada","Ungogo","Warawa","Wudil"};
        public static string[] katsina = {"Bakori","Batagarawa","Batsari","Baure","Bindawa","Charanchi","Dan Musa","Dandume","Danja","Daura","Dutsi",
                                          "Dutsin-Ma","Faskari","Funtua","Ingawa","Jibia","Kafur","Kaita","Kankara","Kankia","Katsina","Kurfi",
                                          "Kusada","Mai’Adua","Malumfashi","Mani","Mashi","Matazu","Musawa","Rimi","Sabuwa","Safana","Sandamu","Zango"};
        public static string[] kebbi = { "Aliero","Arewa Dandi","Argungu","Augie","Bagudo","Birnin Kebbi","Bunza","Dandi","Fakai","Gwandu","Jega","Kalgo",
                                        "Koko/Besse","Maiyama","Ngaski","Sakaba","Shanga","Suru","Danko/Wasagu","Yauri","Zuru"};
        public static string[] sokoto = {"Binji","Bodinga","Dange Shuni","Gada","Goronyo","Gudu","Gwadabawa","Illela","Isa","Kebbe","Kware","Rabah","Sabon Birni",
                                        "Shagari","Silame","Sokoto North","Sokoto South","Tambuwal","Tangaza","Tureta","Wamako","Wurno","Yabo"};
        public static string[] zamfara = {"Anka","Bakura","Birnin Magaji/Kiyaw","Bukkuyum","Bungudu","Tsafe","Gummi","Gusau",
                                         "Kaura Namoda","Maradun","Maru","Shinkafi","Talata Mafara","Zurmi"};
        // SOUTH EAST
        public static string[] southEast = { "Abia", "Anambra", "Ebonyi", "Enugu", "Imo" };
        public static string[] abia = {"Aba North","Aba South","Arochukwu","Bende","Ikwuano","Isiala Ngwa North","Isiala Ngwa South","Isuikwuato","Obi Ngwa",
                                    "Ohafia","Osisioma Ngwa","Ugwunagbo","Ukwa East","Ukwa West","Umuahia North","Umuahia South","Umunneochi"};
        public static string[] anambra = {"Aguata","Awka North","Awka South","Anambra East","Anambra West","Anaocha","Ayamelum","Dunukofia","Ekwusigo",
                                      "Idemili North","Idemili South","Ihiala","Njikoka","Nnewi North","Nnewi South","Ogbaru","Onitsha North","Onitsha South","Orumba North","Orumba South","Oyi"};
        public static string[] ebonyi = { "Abakaliki", "Afikpo North", "Afikpo South", "Ebonyi", "Ezza North", "Ezza South", "Ikwo", "Ishielu", "Ivo", "Izzi", "Ohaozara", "Ohaukwu", "Onicha" };
        public static string[] enugu = { "Aninri","Awgu","Enugu East","Enugu North","Enugu South","Ezeagu","Igbo Etiti","Igbo Eze North",
                                        "Igbo Eze South","Isi Uzo","Nkanu East","Nkanu West","Nsukka","Oji River","Udenu","Udi","Uzo-Uwani"};
        public static string[] imo = { "Aboh Mbaise","Ahiazu Mbaise","Ehime Mbano","Ezinihitte Mbaise","Ideato North","Ideato South","Ihitte/Uboma","Ikeduru",
                                    "Isiala Mbano","Isu","Mbaitoli","Ngor Okpala","Njaba","Nkwerre","Nwangele","Obowo","Oguta","Ohaji/Egbema","Okigwe",
                                     "Onuimo","Orlu","Orsu","Oru East","Oru West","Owerri Municipal","Owerri North","Owerri West"};
        // SOUTH SOUTH
        public static string[] southSouth = { "Akwa Ibom", "Bayelsa", "Cross River", "Rivers", "Delta", "Edo" };
        public static string[] akwaIbom = {"Abak","Eastern Obolo","Eket","Esit-Eket","Essien Udim","Etim-Ekpo","Etinan","Ibeno","Ibesikpo-Asutan","Ibiono-Ibom",
                                            "Ika","Ikono","Ikot Abasi","Ikot Ekpene","Ini","Itu","Mbo","Mkpat-Enin","Nsit-Atai","Nsit-Ibom","Nsit-Ubium","Obot-Akara",
                                        "Okobo","Onna","Oron","Oruk Anam","Ukanafun","Udung-Uko","Uruan","Urue-Offong/Oruko","Uyo"};
        public static string[] bayelsa = {"Brass","Ekeremor","Kolokuma/Opokuma","Nembe","Ogbia","Sagbama","Southern Ijaw","Yenagoa" };
        public static string[] crossRiver = {"Abi","Akamkpa","Akpabuyo","Bakassi","Bekwarra","Biase","Boki","Calabar Municipal","Calabar South",
                                            "Etung","Ikom","Obanliku","Obubra","Obudu","Odukpani","Ogoja","Yakuur","Yala"};
        public static string[] rivers = {"Abua/Odual","Ahoada East","Ahoada West","Akuku Toru","Andoni","Asari-Toru","Bonny","Degema","Emohua","Eleme",
                                     "Etche","Gokana","Ikwerre","Khana","Obio/Akpor","Ogba/Egbema/Ndoni","Ogu/Bolo","Okrika","Omuma","Opobo Nkoro","Oyigbo","Port Harcourt","Tai"};
        public static string[] delta = {"Ethiope East","Ethiope West","Okpe","Sapele","Udu","Ughelli North","Ughelli South","Uvwie","Aniocha North","Aniocha South","Ika North East","Ika South","Ndokwa East",
                                    "Ndokwa West","Oshimili North","Oshimili South","Ukwuani","Bomadi","Burutu","Isoko North","Isoko South","Patani","Warri North","Warri South","Warri South West"};
        public static string[] edo = {"Akoko-Edo","Egor","Esan Central","Esan North-East","Esan South-East","Esan West","Etsako Central","Etsako East","Etsako West",
                                    "Igueben","Ikpoba-Okha","Oredo","Orhionmwon","Ovia North-East","Ovia South-West","Owan East","Owan West","Uhunmwonde"};


        // SOUTH WEST
        public static string[] southWest = { "Ekiti", "Lagos", "Ogun", "Ondo", "Osun", "Oyo" };
        public static string[] ekiti = {"Ado-Ekiti","Ikere","Oye","Aiyekire","Efon","Ekiti East","Ekiti South-West","Ekiti West","Emure",
                                    "Ido-Osi","Ijero","Ikole","Ilejemeje","Irepodun/Ifelodun","Ise/Orun","Moba" };
        public static string[] lagos = {"Agege","Ajeromi-Ifelodun","Alimosho","Amuwo-Odofin","Apapa","Badagry","Epe","Eti-Osa","Ibeju-Lekki","Ifako-Ijaiye",
                                    "Ikeja","Ikorodu","Kosofe","Lagos Island","Lagos Mainland","Mushin","Ojo","Oshodi-Isolo","Shomolu","Surulere" };
        public static string[] ogun = {"Abeokuta North","Abeokuta South","Ado-Odo/Ota","Ewekoro","Ifo","Ijebu East","Ijebu North","Ijebu North-East","Ijebu Ode",
                                    "Ikenne","Imeko Afon","Ipokia","Obafemi Owode","Odogbolu","Odeda","Ogun Waterside","Remo North","Sagamu","Yewa North","Yewa South"};
        public static string[] ondo = {"Akoko North-East","Akoko North-West","Akoko South-East","Akoko South-West","Akure North","Akure South","Ese Odo","Idanre",
                                    "Ifedore","Ilaje","Ile Oluji/Okeigbo","Irele","Odigbo","Okitipupa","Ondo East","Ondo West","Ose","Owo"};
        public static string[] osun = {"Aiyedaade","Aiyedire","Atakumosa East","Atakumosa West","Boluwaduro","Boripe","Ede North","Ede South","Egbedore","Ejigbo","Ife Central",
                                    "Ife East","Ife North","Ife South","Ifedayo","Ifelodun","Ila","Ilesha East","Ilesha West","Irepodun","Irewole","Isokan","Iwo","Obokun",
                                        "Odo-Otin","Ola-Oluwa","Olorunda","Oriade","Orolu","Osogbo"};
        public static string[] oyo = {"Akinyele","Afijio","Egbeda","Ibadan North","Ibadan North-East","Ibadan North-West","Ibadan South-West","Ibadan South-East","Ibarapa Central",
                                    "Ibarapa East","Ido","Irepo","Iseyin","Kajola","Lagelu","Ogbomoso North","Ogbomoso South","Oyo West","Atiba",
                                    "Atisbo","Saki West","Saki East","Itesiwaju","Iwajowa","Ibarapa North","Olorunsogo","Oluyole","Ogo Oluwa","Surulere","Orelope","Ori Ire","Oyo East","Ona Ara"};


        // Arrays of Arrays

        public static string[][] geoPoliticalZones2 = { northCentral, northEast, northWest, southEast, southSouth, southWest, };
        public static string[][] northCentral2 = {benue, kogi, kwara, nasarawa, niger, plateau, fct };
        public static string[][] northEast2 = { adamawa, bauchi, borno, gombe, taraba, yobe };
        public static string[][] northWest2 = { jigawa, kaduna, kano, katsina, kebbi, sokoto, zamfara };
        public static string[][] southEast2 = { abia, anambra, ebonyi, enugu, imo };
        public static string[][] southSouth2 = { akwaIbom, bayelsa, crossRiver, rivers,delta, edo };
        public static string[][] southWest2 = {ekiti, lagos, ogun, ondo, osun, oyo };
        static string StateDirectory()
        {





            return "";
        }

    }
}
