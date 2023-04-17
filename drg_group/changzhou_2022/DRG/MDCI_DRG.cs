namespace drg_group.changzhou_2022
{
    public class MDCI_DRG 
    {
    
        public static bool IG10_group(MedicalRecord record){
            return record.age<=17;
        }
    
        public static bool IJ10_group(MedicalRecord record){
            return record.age<=17;
        }
    
        public static bool IS10_group(MedicalRecord record){
            return record.age<=17;
        }
    
        public static bool IU10_group(MedicalRecord record){
            return record.age<=17;
        }
    
        public static bool IB19_group(MedicalRecord record){
            return true;
        }
    
        public static bool IB29_group(MedicalRecord record){
            return true;
        }
    
        public static bool IB39_group(MedicalRecord record){
            return true;
        }
    
        public static bool IC19_group(MedicalRecord record){
            return true;
        }
    
        public static bool IC29_group(MedicalRecord record){
            return true;
        }
    
        public static bool IC39_group(MedicalRecord record){
            return true;
        }
    
        public static bool IE19_group(MedicalRecord record){
            return true;
        }
    
        public static bool IF19_group(MedicalRecord record){
            return true;
        }
    
        public static bool IF29_group(MedicalRecord record){
            return true;
        }
    
        public static bool IF39_group(MedicalRecord record){
            return true;
        }
    
        public static bool IF49_group(MedicalRecord record){
            return true;
        }
    
        public static bool IF59_group(MedicalRecord record){
            return true;
        }
    
        public static bool IG19_group(MedicalRecord record){
            return true;
        }
    
        public static bool IH19_group(MedicalRecord record){
            return true;
        }
    
        public static bool IT39_group(MedicalRecord record){
            return true;
        }
    
        public static bool IZ19_group(MedicalRecord record){
            return true;
        }
    
        public static bool IR27_group(MedicalRecord record){
            return record.inHospitalTime<5 && (record.leavingType.Equals("2") || record.leavingType.Equals("5"));
        }
    
        public static bool IS27_group(MedicalRecord record){
            return record.inHospitalTime<5 && (record.leavingType.Equals("2") || record.leavingType.Equals("5"));
        }
    
        public static bool IT27_group(MedicalRecord record){
            return record.inHospitalTime<5 && (record.leavingType.Equals("2") || record.leavingType.Equals("5"));
        }
    
        public static bool IU27_group(MedicalRecord record){
            return record.inHospitalTime<5 && (record.leavingType.Equals("2") || record.leavingType.Equals("5"));
        }
    
        public static bool ID11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool IJ11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool IR11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool IR21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool IR31_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool IS11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool IS21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool IT11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool IT21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool IU11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool IU21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool IU31_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool ID13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IJ13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IR13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IR23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IR33_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IS13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IS23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IT13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IT23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IU13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IU23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IU33_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IV13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IZ23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool ID15_group(MedicalRecord record){
            return true;
        }
    
        public static bool IJ15_group(MedicalRecord record){
            return true;
        }
    
        public static bool IR15_group(MedicalRecord record){
            return true;
        }
    
        public static bool IR25_group(MedicalRecord record){
            return true;
        }
    
        public static bool IR35_group(MedicalRecord record){
            return true;
        }
    
        public static bool IS15_group(MedicalRecord record){
            return true;
        }
    
        public static bool IS25_group(MedicalRecord record){
            return true;
        }
    
        public static bool IT15_group(MedicalRecord record){
            return true;
        }
    
        public static bool IT25_group(MedicalRecord record){
            return true;
        }
    
        public static bool IU15_group(MedicalRecord record){
            return true;
        }
    
        public static bool IU25_group(MedicalRecord record){
            return true;
        }
    
        public static bool IU35_group(MedicalRecord record){
            return true;
        }
    
        public static bool IV15_group(MedicalRecord record){
            return true;
        }
    
        public static bool IZ25_group(MedicalRecord record){
            return true;
        }
    
    }
}
