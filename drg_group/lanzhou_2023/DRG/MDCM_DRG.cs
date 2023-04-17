namespace drg_group.lanzhou_2023
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
    
        public static bool MR11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool MD1A_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool MJ1A_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool MS1A_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool MZ1A_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool MR1B_group(MedicalRecord record){
            return true;
        }
    
        public static bool MD15_group(MedicalRecord record){
            return true;
        }
    
        public static bool MJ15_group(MedicalRecord record){
            return true;
        }
    
        public static bool MS15_group(MedicalRecord record){
            return true;
        }
    
        public static bool MZ15_group(MedicalRecord record){
            return true;
        }
    
    }
}
