namespace drg_group.suzhou_2023
{
    public class MDCZ_DRG 
    {
    
        public static bool ZB19_group(MedicalRecord record){
            return true;
        }
    
        public static bool ZC19_group(MedicalRecord record){
            return true;
        }
    
        public static bool ZD19_group(MedicalRecord record){
            return true;
        }
    
        public static bool ZJ19_group(MedicalRecord record){
            return true;
        }
    
        public static bool ZZ11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool ZZ1B_group(MedicalRecord record){
            return true;
        }
    
    }
}
