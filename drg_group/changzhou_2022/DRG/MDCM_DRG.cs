namespace drg_group.changzhou_2022
{
    public class MDCM_DRG 
    {
    
        public static bool MA19_group(MedicalRecord record){
            return true;
        }
    
        public static bool MB19_group(MedicalRecord record){
            return true;
        }
    
        public static bool MC19_group(MedicalRecord record){
            return true;
        }
    
        public static bool MD19_group(MedicalRecord record){
            return true;
        }
    
        public static bool MJ19_group(MedicalRecord record){
            return true;
        }
    
        public static bool MS19_group(MedicalRecord record){
            return true;
        }
    
        public static bool MR11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool MZ11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool MR13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool MZ13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool MR15_group(MedicalRecord record){
            return true;
        }
    
        public static bool MZ15_group(MedicalRecord record){
            return true;
        }
    
    }
}
