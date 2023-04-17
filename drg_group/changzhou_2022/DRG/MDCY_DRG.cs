namespace drg_group.changzhou_2022
{
    public class MDCY_DRG 
    {
    
        public static bool YC19_group(MedicalRecord record){
            return true;
        }
    
        public static bool YR29_group(MedicalRecord record){
            return true;
        }
    
        public static bool YR11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool YR13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool YR15_group(MedicalRecord record){
            return true;
        }
    
    }
}
