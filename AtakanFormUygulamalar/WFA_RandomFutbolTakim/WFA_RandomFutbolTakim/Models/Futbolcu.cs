using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_RandomFutbolTakim.Models
{
    public abstract class Futbolcu : IGuc
    {
       
        Random rnd = new Random();

        public int Kondisyon { get; set; }
        public int IkiliMücadele { get; set; }
        public int Hiz { get; set; }

        public static List<string> kaleciAdi = new List<string>() { "Kameni","Oliver Kahn","Casillas","Buffon","Navas","Kevin Trapp","Dida","Hugo Lloris" }; 
        public static List<string> defansAdi = new List<string>() { "Puyol","Ramos","Varane","Thiago Silva","Chiellini","Serdar Aziz","Servet Çetin","Ferdinand","Pique","J.Terry"}; 
        public static List<string> ortaSahaAdi = new List<string>() { "Ronaldinho","Beckham","Essien","Pirlo","Iniesta","Xavi","Yattara","Diego","Pogba","Casemiro","Modric","Kante","Fernandinho","Sergio Busquets","Eden Hazard","Juninho","Nedved","Kross","Queresma","Figo"}; 
        public static List<string> forvetAdi = new List<string>() { "C.Ronaldo","Messi","Haaland","Mbappe","Ronaldo","Cardozo","Levandowski","İbrahimoviç","Rooney","T.Henry","Pele","Maradona","Suarez","David Villa","Drogba","Sorloth"};


        public abstract string AdVer();
        
        public Futbolcu()
        {
            Kondisyon = rnd.Next(70, 100);
            IkiliMücadele = rnd.Next(70, 100);
            Hiz = rnd.Next(70, 100);   
        }
       

 
    }
}
