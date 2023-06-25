namespace drg_group.qingyang_2023
{
    public class MDCW_DRG 
    {
    
        public static bool WB19_group(MedicalRecord record){
            return true;
        }
    
        public static bool WC19_group(MedicalRecord record){
            return true;
        }
    
        public static bool WR19_group(MedicalRecord record){
            return true;
        }
    
        public static bool WZ11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool WJ13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool WJ15_group(MedicalRecord record){
            return true;
        }
    
        public static bool WZ15_group(MedicalRecord record){
            return true;
        }
    
    }
}
