namespace drg_group.yancheng_2023
{
    public class MDCD_DRG 
    {
    
        public static bool DA19_group(MedicalRecord record){
            return true;
        }
    
        public static bool DB19_group(MedicalRecord record){
            return true;
        }
    
        public static bool DB29_group(MedicalRecord record){
            return true;
        }
    
        public static bool DB39_group(MedicalRecord record){
            return true;
        }
    
        public static bool DC19_group(MedicalRecord record){
            return true;
        }
    
        public static bool DC29_group(MedicalRecord record){
            return true;
        }
    
        public static bool DD19_group(MedicalRecord record){
            return true;
        }
    
        public static bool DD29_group(MedicalRecord record){
            return true;
        }
    
        public static bool DE29_group(MedicalRecord record){
            return true;
        }
    
        public static bool DG19_group(MedicalRecord record){
            return true;
        }
    
        public static bool DG29_group(MedicalRecord record){
            return true;
        }
    
        public static bool DK19_group(MedicalRecord record){
            return true;
        }
    
        public static bool DR19_group(MedicalRecord record){
            return true;
        }
    
        public static bool DS19_group(MedicalRecord record){
            return true;
        }
    
        public static bool DT19_group(MedicalRecord record){
            return true;
        }
    
        public static bool DT29_group(MedicalRecord record){
            return true;
        }
    
        public static bool DU19_group(MedicalRecord record){
            return true;
        }
    
        public static bool DV19_group(MedicalRecord record){
            return true;
        }
    
        public static bool DW19_group(MedicalRecord record){
            return true;
        }
    
        public static bool DZ19_group(MedicalRecord record){
            return true;
        }
    
        public static bool DE13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool DJ13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool DE15_group(MedicalRecord record){
            return true;
        }
    
        public static bool DJ15_group(MedicalRecord record){
            return true;
        }
    
    }
}
