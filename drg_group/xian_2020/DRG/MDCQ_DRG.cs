namespace drg_group.xian_2020
{
    public class MDCQ_DRG 
    {
    
        public static bool QB19_group(MedicalRecord record){
            return true;
        }
    
        public static bool QC19_group(MedicalRecord record){
            return true;
        }
    
        public static bool QJ19_group(MedicalRecord record){
            return true;
        }
    
        public static bool QS19_group(MedicalRecord record){
            return true;
        }
    
        public static bool QS49_group(MedicalRecord record){
            return true;
        }
    
        public static bool QT19_group(MedicalRecord record){
            return true;
        }
    
        public static bool QD11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool QR11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool QS21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool QS31_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool QD13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool QR13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool QS23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool QS33_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool QD15_group(MedicalRecord record){
            return true;
        }
    
        public static bool QR15_group(MedicalRecord record){
            return true;
        }
    
        public static bool QS25_group(MedicalRecord record){
            return true;
        }
    
        public static bool QS35_group(MedicalRecord record){
            return true;
        }
    
    }
}
