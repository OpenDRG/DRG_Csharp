namespace drg_group.yancheng_2023
{
    public class MDCJ_DRG 
    {
    
        public static bool JA19_group(MedicalRecord record){
            return true;
        }
    
        public static bool JA29_group(MedicalRecord record){
            return true;
        }
    
        public static bool JB19_group(MedicalRecord record){
            return true;
        }
    
        public static bool JB29_group(MedicalRecord record){
            return true;
        }
    
        public static bool JB39_group(MedicalRecord record){
            return true;
        }
    
        public static bool JC19_group(MedicalRecord record){
            return true;
        }
    
        public static bool JD29_group(MedicalRecord record){
            return true;
        }
    
        public static bool JR19_group(MedicalRecord record){
            return true;
        }
    
        public static bool JS29_group(MedicalRecord record){
            return true;
        }
    
        public static bool JT19_group(MedicalRecord record){
            return true;
        }
    
        public static bool JV19_group(MedicalRecord record){
            return true;
        }
    
        public static bool JV29_group(MedicalRecord record){
            return true;
        }
    
        public static bool JZ19_group(MedicalRecord record){
            return true;
        }
    
        public static bool JS11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool JU11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool JD13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool JJ13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool JR23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool JS13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool JU13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool JD15_group(MedicalRecord record){
            return true;
        }
    
        public static bool JJ15_group(MedicalRecord record){
            return true;
        }
    
        public static bool JR25_group(MedicalRecord record){
            return true;
        }
    
        public static bool JS15_group(MedicalRecord record){
            return true;
        }
    
        public static bool JU15_group(MedicalRecord record){
            return true;
        }
    
    }
}
