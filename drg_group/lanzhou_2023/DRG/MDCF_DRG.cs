namespace drg_group.lanzhou_2023
{
    public class MDCF_DRG 
    {
    
        public static bool FB19_group(MedicalRecord record){
            return true;
        }
    
        public static bool FD39_group(MedicalRecord record){
            return true;
        }
    
        public static bool FE19_group(MedicalRecord record){
            return true;
        }
    
        public static bool FK19_group(MedicalRecord record){
            return true;
        }
    
        public static bool FK29_group(MedicalRecord record){
            return true;
        }
    
        public static bool FK39_group(MedicalRecord record){
            return true;
        }
    
        public static bool FL19_group(MedicalRecord record){
            return true;
        }
    
        public static bool FL39_group(MedicalRecord record){
            return true;
        }
    
        public static bool FM19_group(MedicalRecord record){
            return true;
        }
    
        public static bool FM29_group(MedicalRecord record){
            return true;
        }
    
        public static bool FM39_group(MedicalRecord record){
            return true;
        }
    
        public static bool FN19_group(MedicalRecord record){
            return true;
        }
    
        public static bool FR39_group(MedicalRecord record){
            return true;
        }
    
        public static bool FT29_group(MedicalRecord record){
            return true;
        }
    
        public static bool FB21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FC11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FD11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FD21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FE21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FF31_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FJ11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FN21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FP11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FR11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FR21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FR41_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FT11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FT31_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FT41_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FU11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FU21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FV21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FW11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FW21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FZ11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FF1A_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FF2A_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FL2A_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FM4A_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FV1A_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FV3A_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FD13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FD23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FF33_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FJ13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FN23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FR43_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FT13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FT43_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FU23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FW23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FB2B_group(MedicalRecord record){
            return true;
        }
    
        public static bool FC1B_group(MedicalRecord record){
            return true;
        }
    
        public static bool FE2B_group(MedicalRecord record){
            return true;
        }
    
        public static bool FP1B_group(MedicalRecord record){
            return true;
        }
    
        public static bool FR1B_group(MedicalRecord record){
            return true;
        }
    
        public static bool FR2B_group(MedicalRecord record){
            return true;
        }
    
        public static bool FT3B_group(MedicalRecord record){
            return true;
        }
    
        public static bool FU1B_group(MedicalRecord record){
            return true;
        }
    
        public static bool FV2B_group(MedicalRecord record){
            return true;
        }
    
        public static bool FW1B_group(MedicalRecord record){
            return true;
        }
    
        public static bool FZ1B_group(MedicalRecord record){
            return true;
        }
    
        public static bool FD15_group(MedicalRecord record){
            return true;
        }
    
        public static bool FD25_group(MedicalRecord record){
            return true;
        }
    
        public static bool FF15_group(MedicalRecord record){
            return true;
        }
    
        public static bool FF25_group(MedicalRecord record){
            return true;
        }
    
        public static bool FF35_group(MedicalRecord record){
            return true;
        }
    
        public static bool FJ15_group(MedicalRecord record){
            return true;
        }
    
        public static bool FL25_group(MedicalRecord record){
            return true;
        }
    
        public static bool FM45_group(MedicalRecord record){
            return true;
        }
    
        public static bool FN25_group(MedicalRecord record){
            return true;
        }
    
        public static bool FR45_group(MedicalRecord record){
            return true;
        }
    
        public static bool FT15_group(MedicalRecord record){
            return true;
        }
    
        public static bool FT45_group(MedicalRecord record){
            return true;
        }
    
        public static bool FU25_group(MedicalRecord record){
            return true;
        }
    
        public static bool FV15_group(MedicalRecord record){
            return true;
        }
    
        public static bool FV35_group(MedicalRecord record){
            return true;
        }
    
        public static bool FW25_group(MedicalRecord record){
            return true;
        }
    
    }
}
