namespace drg_group.changzhou_2022
{
    public class MDCU_DRG 
    {
    
        public static bool US19_group(MedicalRecord record){
            return true;
        }
    
        public static bool UR11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool UR13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool UR15_group(MedicalRecord record){
            return true;
        }
    
    }
}
