namespace mis_221_lab_oop_uyentruong2003
{
    public class Television
    {

        private string manufacturer;
        private int screenSize;
        private bool powerOn;
        private int channel;
        private int volume;

        public Television(){

        }

        // Constructor: create the object and initialize the instances of class Television
        public Television(string manufacturer, int screenSize){
            this.manufacturer = manufacturer;
            this.screenSize = screenSize;
            this.powerOn = false;
            this.volume = 20;
            this.channel = 2;
        }

        // --ACCESSOR METHODS: return the value of the corresponding fields

        public int GetVolume(){
            return volume;
        }

        public int GetChannel(){
            return channel;
        }

        public string GetManufacturer(){
            return manufacturer;
        }

        public int GetScreenSize(){
            return screenSize;
        }

        // --MUTATOR METHODS: update the value of the corresponding fields

        // SetChannel: accepts a value to be stored in the channel field
        public void SetChannel(int station){
            this.channel = station;
        }

        // Power: changes the state of the power button between ON/OFF (True/False)
        public void Power(){
            this.powerOn = !powerOn;
        }

        // IncreaseVolume: increases the volume by 1
        public void IncreaseVolume(){
            this.volume ++;
        }

        // DecreaseVolume: decreases the volume by 1
        public void DecreaseVolume(){
            this.volume--;
        }
        
        // ToString: defines what is output at the end
        public override string ToString(){
            if (this.powerOn) return $"A {screenSize}-inch {manufacturer} TV has been turned ON.";
            else return $"A {screenSize}-inch {manufacturer} TV has been turned OFF.";
        }
        
    }
}