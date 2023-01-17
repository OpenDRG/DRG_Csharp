namespace drg_group.wuxi_2022
{
    public class MDCA_DRG 
    {
    
        public static bool AG19_group(MedicalRecord record){
            return true;
        }
    
        public static bool AG29_group(MedicalRecord record){
            return true;
        }
    
        public static bool AF19_group(MedicalRecord record){
            return true;
        }
    
        public static bool AH11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
    }
}
