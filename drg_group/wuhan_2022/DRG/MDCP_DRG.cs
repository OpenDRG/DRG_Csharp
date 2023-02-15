namespace drg_group.wuhan_2022
{
    public class MDCP_DRG 
    {
    
        public static bool PB19_group(MedicalRecord record){
            return true;
        }
    
        public static bool PC19_group(MedicalRecord record){
            return true;
        }
    
        public static bool PJ19_group(MedicalRecord record){
            return true;
        }
    
        public static bool PR19_group(MedicalRecord record){
            return true;
        }
    
        public static bool PS19_group(MedicalRecord record){
            return true;
        }
    
        public static bool PT19_group(MedicalRecord record){
            return true;
        }
    
        public static bool PT29_group(MedicalRecord record){
            return true;
        }
    
        public static bool PV19_group(MedicalRecord record){
            return true;
        }
    
        public static bool PK11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool PU1A_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool PK1B_group(MedicalRecord record){
            return true;
        }
    
        public static bool PU15_group(MedicalRecord record){
            return true;
        }
    
    }
}
