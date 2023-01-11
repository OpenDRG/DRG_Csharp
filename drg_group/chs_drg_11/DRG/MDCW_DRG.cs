namespace drg_group.chs_drg_11
{
    public class MDCW_DRG 
    {
    
        public static bool WB19_group(MedicalRecord record){
            return true;
        }
    
        public static bool WC19_group(MedicalRecord record){
            return true;
        }
    
        public static bool WJ19_group(MedicalRecord record){
            return true;
        }
    
        public static bool WR19_group(MedicalRecord record){
            return true;
        }
    
        public static bool WZ13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool WZ15_group(MedicalRecord record){
            return true;
        }
    
    }
}
