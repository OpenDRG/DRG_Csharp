namespace drg_group.changzhou_2022
{
    public class MDCK_DRG 
    {
    
        public static bool KT10_group(MedicalRecord record){
            return record.age<=17;
        }
    
        public static bool KB19_group(MedicalRecord record){
            return true;
        }
    
        public static bool KC19_group(MedicalRecord record){
            return true;
        }
    
        public static bool KD19_group(MedicalRecord record){
            return true;
        }
    
        public static bool KD29_group(MedicalRecord record){
            return true;
        }
    
        public static bool KE19_group(MedicalRecord record){
            return true;
        }
    
        public static bool KF19_group(MedicalRecord record){
            return true;
        }
    
        public static bool KR19_group(MedicalRecord record){
            return true;
        }
    
        public static bool KV19_group(MedicalRecord record){
            return true;
        }
    
        public static bool KS17_group(MedicalRecord record){
            return record.inHospitalTime<5 && (record.leavingType.Equals("2") || record.leavingType.Equals("5"));
        }
    
        public static bool KJ11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool KS11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool KT11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool KU11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool KZ11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool KJ13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool KS13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool KT13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool KU13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool KZ13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool KJ15_group(MedicalRecord record){
            return true;
        }
    
        public static bool KS15_group(MedicalRecord record){
            return true;
        }
    
        public static bool KT15_group(MedicalRecord record){
            return true;
        }
    
        public static bool KU15_group(MedicalRecord record){
            return true;
        }
    
        public static bool KZ15_group(MedicalRecord record){
            return true;
        }
    
    }
}
