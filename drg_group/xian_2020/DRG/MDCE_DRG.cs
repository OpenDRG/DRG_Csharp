namespace drg_group.xian_2020
{
    public class MDCE_DRG 
    {
    
        public static bool EB19_group(MedicalRecord record){
            return true;
        }
    
        public static bool EC19_group(MedicalRecord record){
            return true;
        }
    
        public static bool ED19_group(MedicalRecord record){
            return true;
        }
    
        public static bool EJ19_group(MedicalRecord record){
            return true;
        }
    
        public static bool ER29_group(MedicalRecord record){
            return true;
        }
    
        public static bool ES19_group(MedicalRecord record){
            return true;
        }
    
        public static bool ES29_group(MedicalRecord record){
            return true;
        }
    
        public static bool ET19_group(MedicalRecord record){
            return true;
        }
    
        public static bool ET29_group(MedicalRecord record){
            return true;
        }
    
        public static bool EU19_group(MedicalRecord record){
            return true;
        }
    
        public static bool EV19_group(MedicalRecord record){
            return true;
        }
    
        public static bool EW19_group(MedicalRecord record){
            return true;
        }
    
        public static bool EX19_group(MedicalRecord record){
            return true;
        }
    
        public static bool EX29_group(MedicalRecord record){
            return true;
        }
    
        public static bool EZ19_group(MedicalRecord record){
            return true;
        }
    
        public static bool ER11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool ER31_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool ER13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool ER33_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool ER15_group(MedicalRecord record){
            return true;
        }
    
        public static bool ER35_group(MedicalRecord record){
            return true;
        }
    
    }
}
