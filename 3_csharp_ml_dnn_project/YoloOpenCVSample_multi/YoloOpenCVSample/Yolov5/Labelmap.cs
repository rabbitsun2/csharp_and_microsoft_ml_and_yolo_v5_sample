namespace OnnxSample.Yolov5
{
    public class LabelMap
    {
        public static readonly string[] Labels = new[] { 
            "all",
            "GLASS", 
            "CARDBOARD",
            "METAL",
            "PAPER",
            "BIODEGRADABLE",
            "PLASTIC"
        };


        public static readonly string[] Labels_pcb = new[] {
            "all",
            "Button",
            "Capacitor",
            "Connector",
            "Pins",
            "Capacitor Jumper",
            "Diode", 
            "EM",
            "Electrolytic Capacitor",
            "IC",
            "Ferrite Bead",
            "Inductor",
            "Jumper",
            "Led",
            "Pads",
            "Clock",
            "Resistor Jumper",
            "Resistor Network",
            "Resistor",
            "Switch",
            "Test Point",
            "Transistor",
            "Unknown Unlabeled",
            "iC"
        };

    }

}
