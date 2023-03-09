namespace drg_group.fuzhou_2022
{
    public class MDCA_DRG 
    {
    
        public static bool AH11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool AH15_group(MedicalRecord record){
            return true;
        }
    
    }
}
