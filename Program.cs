using System;

namespace assignment_2_question2
{

    class FALCON
    {
        private string _FalconName;
        private string _Species;
        private string _Sex;
        private string _Weight;
        private string _BandNumber;
        public string FalconName
        {
            set
            {
                _FalconName = value;
            }

        }
        public string Species
        {
            set
            {
                _Species = value;
            }

        }
        public string Sex
        {
            set
            {
                _Sex = value;
            }

        }
        public string Weight
        {
            set
            {
                _Weight = value;
            }

        }
        public string BandNumber
        {
            set
            {
                _BandNumber = value;
            }

        }

        public FALCON(string _falconname, string _species, string _sex, string _weight, string _bandnumber)
        {
            FalconName = _falconname;
            Species = _species;
            Sex = _sex;
            Weight = _weight;
            BandNumber = _bandnumber;

            displayFalcon();
        }

        public string displayFalcon()
        {
            var showfalcon = "FALCON DATA OUTPUT \n\n";
            showfalcon += $"Falcon Name: {_FalconName}\n";
            showfalcon += $"Species: {_Species}\n";
            showfalcon += $"Sex: {_Sex}\n";
            showfalcon += $"Weight: {_Weight}\n";
            showfalcon += $"Band Number: {_BandNumber}\n";

             return showfalcon;


        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var FALCON = new FALCON("Hisan", "NZ Falcon", "Male", "240grams", "H39878");
            

        }
    }
}
