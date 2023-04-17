namespace drg_group.suzhou_2023
{
    public class MDCO_DRG 
    {
    
        public static bool OB19_group(MedicalRecord record){
            return true;
        }
    
        public static bool OC19_group(MedicalRecord record){
            return true;
        }
    
        public static bool OD19_group(MedicalRecord record){
            return true;
        }
    
        public static bool OD29_group(MedicalRecord record){
            return true;
        }
    
        public static bool OE19_group(MedicalRecord record){
            return true;
        }
    
        public static bool OF19_group(MedicalRecord record){
            return true;
        }
    
        public static bool OF29_group(MedicalRecord record){
            return true;
        }
    
        public static bool OJ19_group(MedicalRecord record){
            return true;
        }
    
        public static bool OR19_group(MedicalRecord record){
            return true;
        }
    
        public static bool OZ19_group(MedicalRecord record){
            return true;
        }
    
        public static bool OS21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool OS1A_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool OT1A_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool OS2B_group(MedicalRecord record){
            return true;
        }
    
        public static bool OS15_group(MedicalRecord record){
            return true;
        }
    
        public static bool OT15_group(MedicalRecord record){
            return true;
        }
    
    }
}
