namespace drg_group.chs_drg_10
{
    public class MDCG_DRG 
    {
    
        public static bool GB19_group(MedicalRecord record){
            return true;
        }
    
        public static bool GB29_group(MedicalRecord record){
            return true;
        }
    
        public static bool GC19_group(MedicalRecord record){
            return true;
        }
    
        public static bool GC29_group(MedicalRecord record){
            return true;
        }
    
        public static bool GD19_group(MedicalRecord record){
            return true;
        }
    
        public static bool GD29_group(MedicalRecord record){
            return true;
        }
    
        public static bool GE19_group(MedicalRecord record){
            return true;
        }
    
        public static bool GF19_group(MedicalRecord record){
            return true;
        }
    
        public static bool GF29_group(MedicalRecord record){
            return true;
        }
    
        public static bool GG19_group(MedicalRecord record){
            return true;
        }
    
        public static bool GK19_group(MedicalRecord record){
            return true;
        }
    
        public static bool GK29_group(MedicalRecord record){
            return true;
        }
    
        public static bool GK39_group(MedicalRecord record){
            return true;
        }
    
        public static bool GS19_group(MedicalRecord record){
            return true;
        }
    
        public static bool GU19_group(MedicalRecord record){
            return true;
        }
    
        public static bool GU29_group(MedicalRecord record){
            return true;
        }
    
        public static bool GW19_group(MedicalRecord record){
            return true;
        }
    
        public static bool GZ19_group(MedicalRecord record){
            return true;
        }
    
        public static bool GE21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool GJ11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool GR11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool GT11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool GV11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool GE23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool GJ13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool GR13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool GT13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool GV13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool GE25_group(MedicalRecord record){
            return true;
        }
    
        public static bool GJ15_group(MedicalRecord record){
            return true;
        }
    
        public static bool GR15_group(MedicalRecord record){
            return true;
        }
    
        public static bool GT15_group(MedicalRecord record){
            return true;
        }
    
        public static bool GV15_group(MedicalRecord record){
            return true;
        }
    
    }
}
