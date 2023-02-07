namespace drg_group.wuhan_2022
{
    public class MDCF_DRG 
    {
    
        public static bool FN19_group(MedicalRecord record){
            return true;
        }
    
        public static bool FR39_group(MedicalRecord record){
            return true;
        }
    
        public static bool FB19_group(MedicalRecord record){
            return true;
        }
    
        public static bool FT29_group(MedicalRecord record){
            return true;
        }
    
        public static bool FC19_group(MedicalRecord record){
            return true;
        }
    
        public static bool FK39_group(MedicalRecord record){
            return true;
        }
    
        public static bool FC39_group(MedicalRecord record){
            return true;
        }
    
        public static bool FC29_group(MedicalRecord record){
            return true;
        }
    
        public static bool FD19_group(MedicalRecord record){
            return true;
        }
    
        public static bool FT39_group(MedicalRecord record){
            return true;
        }
    
        public static bool FF19_group(MedicalRecord record){
            return true;
        }
    
        public static bool FM29_group(MedicalRecord record){
            return true;
        }
    
        public static bool FR29_group(MedicalRecord record){
            return true;
        }
    
        public static bool FD39_group(MedicalRecord record){
            return true;
        }
    
        public static bool FU19_group(MedicalRecord record){
            return true;
        }
    
        public static bool FK29_group(MedicalRecord record){
            return true;
        }
    
        public static bool FK19_group(MedicalRecord record){
            return true;
        }
    
        public static bool FB29_group(MedicalRecord record){
            return true;
        }
    
        public static bool FV49_group(MedicalRecord record){
            return true;
        }
    
        public static bool FM19_group(MedicalRecord record){
            return true;
        }
    
        public static bool FV29_group(MedicalRecord record){
            return true;
        }
    
        public static bool FS19_group(MedicalRecord record){
            return true;
        }
    
        public static bool FW19_group(MedicalRecord record){
            return true;
        }
    
        public static bool FL19_group(MedicalRecord record){
            return true;
        }
    
        public static bool FU21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FR11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FB31_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FT11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FF31_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FV11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FR41_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FN21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FZ11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FE11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FW21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FV3A_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FD2A_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FM3A_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FL2A_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FF4A_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FF2A_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FJ1A_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FB33_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FU23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FZ13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FF33_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FR1B_group(MedicalRecord record){
            return true;
        }
    
        public static bool FR4B_group(MedicalRecord record){
            return true;
        }
    
        public static bool FE1B_group(MedicalRecord record){
            return true;
        }
    
        public static bool FN2B_group(MedicalRecord record){
            return true;
        }
    
        public static bool FW2B_group(MedicalRecord record){
            return true;
        }
    
        public static bool FT1B_group(MedicalRecord record){
            return true;
        }
    
        public static bool FV1B_group(MedicalRecord record){
            return true;
        }
    
        public static bool FL25_group(MedicalRecord record){
            return true;
        }
    
        public static bool FM35_group(MedicalRecord record){
            return true;
        }
    
        public static bool FZ15_group(MedicalRecord record){
            return true;
        }
    
        public static bool FF45_group(MedicalRecord record){
            return true;
        }
    
        public static bool FD25_group(MedicalRecord record){
            return true;
        }
    
        public static bool FJ15_group(MedicalRecord record){
            return true;
        }
    
        public static bool FV35_group(MedicalRecord record){
            return true;
        }
    
        public static bool FB35_group(MedicalRecord record){
            return true;
        }
    
        public static bool FF25_group(MedicalRecord record){
            return true;
        }
    
        public static bool FF35_group(MedicalRecord record){
            return true;
        }
    
        public static bool FU25_group(MedicalRecord record){
            return true;
        }
    
    }
}
