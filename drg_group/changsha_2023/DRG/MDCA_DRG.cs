namespace drg_group.changsha_2023
{
    public class MDCA_DRG 
    {
    
        public static bool AA19_group(MedicalRecord record){
            return true;
        }
    
        public static bool AB19_group(MedicalRecord record){
            return true;
        }
    
        public static bool AC19_group(MedicalRecord record){
            return true;
        }
    
        public static bool AD19_group(MedicalRecord record){
            return true;
        }
    
        public static bool AE19_group(MedicalRecord record){
            return true;
        }
    
        public static bool AF19_group(MedicalRecord record){
            return true;
        }
    
        public static bool AG19_group(MedicalRecord record){
            return true;
        }
    
        public static bool AG29_group(MedicalRecord record){
            return true;
        }
    
        public static bool AH11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool AH15_group(MedicalRecord record){
            return true;
        }
    
    }
}
