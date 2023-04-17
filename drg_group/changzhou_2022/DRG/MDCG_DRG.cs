namespace drg_group.changzhou_2022
{
    public class MDCG_DRG 
    {
    
        public static bool GU10_group(MedicalRecord record){
            return record.age<=17;
        }
    
        public static bool GV10_group(MedicalRecord record){
            return record.age<=17;
        }
    
        public static bool GW10_group(MedicalRecord record){
            return record.age<=17;
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
    
        public static bool GU29_group(MedicalRecord record){
            return true;
        }
    
        public static bool GW19_group(MedicalRecord record){
            return true;
        }
    
        public static bool GZ19_group(MedicalRecord record){
            return true;
        }
    
        public static bool GB17_group(MedicalRecord record){
            return record.inHospitalTime<5 && (record.leavingType.Equals("2") || record.leavingType.Equals("5"));
        }
    
        public static bool GB27_group(MedicalRecord record){
            return record.inHospitalTime<5 && (record.leavingType.Equals("2") || record.leavingType.Equals("5"));
        }
    
        public static bool GC17_group(MedicalRecord record){
            return record.inHospitalTime<5 && (record.leavingType.Equals("2") || record.leavingType.Equals("5"));
        }
    
        public static bool GR17_group(MedicalRecord record){
            return record.inHospitalTime<5 && (record.leavingType.Equals("2") || record.leavingType.Equals("5"));
        }
    
        public static bool GS17_group(MedicalRecord record){
            return record.inHospitalTime<5 && (record.leavingType.Equals("2") || record.leavingType.Equals("5"));
        }
    
        public static bool GB11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool GB21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool GC11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool GC21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
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
    
        public static bool GS11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool GT11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool GU11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool GV11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool GB13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool GB23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool GC13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
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
    
        public static bool GS13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool GT13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool GU13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool GV13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool GB15_group(MedicalRecord record){
            return true;
        }
    
        public static bool GB25_group(MedicalRecord record){
            return true;
        }
    
        public static bool GC15_group(MedicalRecord record){
            return true;
        }
    
        public static bool GC25_group(MedicalRecord record){
            return true;
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
    
        public static bool GS15_group(MedicalRecord record){
            return true;
        }
    
        public static bool GT15_group(MedicalRecord record){
            return true;
        }
    
        public static bool GU15_group(MedicalRecord record){
            return true;
        }
    
        public static bool GV15_group(MedicalRecord record){
            return true;
        }
    
    }
}
