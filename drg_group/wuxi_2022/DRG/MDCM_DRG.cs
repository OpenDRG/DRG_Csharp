namespace drg_group.wuxi_2022
{
    public class MDCM_DRG 
    {
    
        public static bool MZ19_group(MedicalRecord record){
            return true;
        }
    
        public static bool MB19_group(MedicalRecord record){
            return true;
        }
    
        public static bool MA19_group(MedicalRecord record){
            return true;
        }
    
        public static bool MJ19_group(MedicalRecord record){
            return true;
        }
    
        public static bool MC19_group(MedicalRecord record){
            return true;
        }
    
        public static bool MR11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool MS13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool MD13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool MD15_group(MedicalRecord record){
            return true;
        }
    
        public static bool MR15_group(MedicalRecord record){
            return true;
        }
    
        public static bool MS15_group(MedicalRecord record){
            return true;
        }
    
    }
}
