namespace drg_group.linfen_2022
{
    public class MDCP_DRG 
    {
    
        public static bool PK19_group(MedicalRecord record){
            return true;
        }
    
        public static bool PR19_group(MedicalRecord record){
            return true;
        }
    
        public static bool PS19_group(MedicalRecord record){
            return true;
        }
    
        public static bool PS39_group(MedicalRecord record){
            return true;
        }
    
        public static bool PS49_group(MedicalRecord record){
            return true;
        }
    
        public static bool PV19_group(MedicalRecord record){
            return true;
        }
    
        public static bool PU11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool PU15_group(MedicalRecord record){
            return true;
        }
    
    }
}
