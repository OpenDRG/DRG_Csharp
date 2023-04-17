namespace drg_group.wlmq_2022
{
    public class MDCY_DRG 
    {
    
        public static bool YR19_group(MedicalRecord record){
            return true;
        }
    
        public static bool YR21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool YC13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool YR23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool YC15_group(MedicalRecord record){
            return true;
        }
    
        public static bool YR25_group(MedicalRecord record){
            return true;
        }
    
    }
}
