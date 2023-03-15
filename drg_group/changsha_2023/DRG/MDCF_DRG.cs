namespace drg_group.changsha_2023
{
    public class MDCF_DRG 
    {
    
        public static bool FB19_group(MedicalRecord record){
            return true;
        }
    
        public static bool FB29_group(MedicalRecord record){
            return true;
        }
    
        public static bool FD39_group(MedicalRecord record){
            return true;
        }
    
        public static bool FE19_group(MedicalRecord record){
            return true;
        }
    
        public static bool FE29_group(MedicalRecord record){
            return true;
        }
    
        public static bool FF19_group(MedicalRecord record){
            return true;
        }
    
        public static bool FJ19_group(MedicalRecord record){
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
    
        public static bool FM29_group(MedicalRecord record){
            return true;
        }
    
        public static bool FM49_group(MedicalRecord record){
            return true;
        }
    
        public static bool FN19_group(MedicalRecord record){
            return true;
        }
    
        public static bool FP19_group(MedicalRecord record){
            return true;
        }
    
        public static bool FR19_group(MedicalRecord record){
            return true;
        }
    
        public static bool FR49_group(MedicalRecord record){
            return true;
        }
    
        public static bool FT29_group(MedicalRecord record){
            return true;
        }
    
        public static bool FU29_group(MedicalRecord record){
            return true;
        }
    
        public static bool FV1A_CS_group(MedicalRecord record){
            return record.age<=6;
        }
    
        public static bool FV1B_CS_group(MedicalRecord record){
            return true;
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
    
        public static bool FF31_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FL21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FM11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FM31_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FN21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FR21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FR31_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FT11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FT41_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FU11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FV21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FV31_group(MedicalRecord record){
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
    
        public static bool FD23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FF23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FF33_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FT13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FT33_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FU13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FZ13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FC15_group(MedicalRecord record){
            return true;
        }
    
        public static bool FD15_group(MedicalRecord record){
            return true;
        }
    
        public static bool FD25_group(MedicalRecord record){
            return true;
        }
    
        public static bool FF25_group(MedicalRecord record){
            return true;
        }
    
        public static bool FF35_group(MedicalRecord record){
            return true;
        }
    
        public static bool FL25_group(MedicalRecord record){
            return true;
        }
    
        public static bool FM15_group(MedicalRecord record){
            return true;
        }
    
        public static bool FM35_group(MedicalRecord record){
            return true;
        }
    
        public static bool FN25_group(MedicalRecord record){
            return true;
        }
    
        public static bool FR25_group(MedicalRecord record){
            return true;
        }
    
        public static bool FR35_group(MedicalRecord record){
            return true;
        }
    
        public static bool FT15_group(MedicalRecord record){
            return true;
        }
    
        public static bool FT35_group(MedicalRecord record){
            return true;
        }
    
        public static bool FT45_group(MedicalRecord record){
            return true;
        }
    
        public static bool FU15_group(MedicalRecord record){
            return true;
        }
    
        public static bool FV25_group(MedicalRecord record){
            return true;
        }
    
        public static bool FV35_group(MedicalRecord record){
            return true;
        }
    
        public static bool FW15_group(MedicalRecord record){
            return true;
        }
    
        public static bool FW25_group(MedicalRecord record){
            return true;
        }
    
        public static bool FZ15_group(MedicalRecord record){
            return true;
        }
    
    }
}
