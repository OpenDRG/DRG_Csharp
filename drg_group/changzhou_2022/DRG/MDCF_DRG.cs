namespace drg_group.changzhou_2022
{
    public class MDCF_DRG 
    {
    
        public static bool FT10_group(MedicalRecord record){
            return record.age<=17;
        }
    
        public static bool FT30_group(MedicalRecord record){
            return record.age<=17;
        }
    
        public static bool FB19_group(MedicalRecord record){
            return true;
        }
    
        public static bool FB29_group(MedicalRecord record){
            return true;
        }
    
        public static bool FB39_group(MedicalRecord record){
            return true;
        }
    
        public static bool FC19_group(MedicalRecord record){
            return true;
        }
    
        public static bool FC29_group(MedicalRecord record){
            return true;
        }
    
        public static bool FC39_group(MedicalRecord record){
            return true;
        }
    
        public static bool FD19_group(MedicalRecord record){
            return true;
        }
    
        public static bool FD29_group(MedicalRecord record){
            return true;
        }
    
        public static bool FD39_group(MedicalRecord record){
            return true;
        }
    
        public static bool FE19_group(MedicalRecord record){
            return true;
        }
    
        public static bool FF19_group(MedicalRecord record){
            return true;
        }
    
        public static bool FF49_group(MedicalRecord record){
            return true;
        }
    
        public static bool FJ19_group(MedicalRecord record){
            return true;
        }
    
        public static bool FK19_group(MedicalRecord record){
            return true;
        }
    
        public static bool FK29_group(MedicalRecord record){
            return true;
        }
    
        public static bool FK39_group(MedicalRecord record){
            return true;
        }
    
        public static bool FL19_group(MedicalRecord record){
            return true;
        }
    
        public static bool FL29_group(MedicalRecord record){
            return true;
        }
    
        public static bool FM19_group(MedicalRecord record){
            return true;
        }
    
        public static bool FM29_group(MedicalRecord record){
            return true;
        }
    
        public static bool FM39_group(MedicalRecord record){
            return true;
        }
    
        public static bool FN29_group(MedicalRecord record){
            return true;
        }
    
        public static bool FS19_group(MedicalRecord record){
            return true;
        }
    
        public static bool FV29_group(MedicalRecord record){
            return true;
        }
    
        public static bool FV49_group(MedicalRecord record){
            return true;
        }
    
        public static bool FR17_group(MedicalRecord record){
            return record.inHospitalTime<5 && (record.leavingType.Equals("2") || record.leavingType.Equals("5"));
        }
    
        public static bool FR37_group(MedicalRecord record){
            return record.inHospitalTime<5 && (record.leavingType.Equals("2") || record.leavingType.Equals("5"));
        }
    
        public static bool FR47_group(MedicalRecord record){
            return record.inHospitalTime<5 && (record.leavingType.Equals("2") || record.leavingType.Equals("5"));
        }
    
        public static bool FU17_group(MedicalRecord record){
            return record.inHospitalTime<5 && (record.leavingType.Equals("2") || record.leavingType.Equals("5"));
        }
    
        public static bool FU27_group(MedicalRecord record){
            return record.inHospitalTime<5 && (record.leavingType.Equals("2") || record.leavingType.Equals("5"));
        }
    
        public static bool FW17_group(MedicalRecord record){
            return record.inHospitalTime<5 && (record.leavingType.Equals("2") || record.leavingType.Equals("5"));
        }
    
        public static bool FW27_group(MedicalRecord record){
            return record.inHospitalTime<5 && (record.leavingType.Equals("2") || record.leavingType.Equals("5"));
        }
    
        public static bool FZ17_group(MedicalRecord record){
            return record.inHospitalTime<5 && (record.leavingType.Equals("2") || record.leavingType.Equals("5"));
        }
    
        public static bool FF21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FF31_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FN11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FR11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FR21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FR31_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FR41_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FT11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FT21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FT31_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FU11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FU21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FV11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FW11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FW21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FZ11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FF23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FF33_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FN13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FR13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FR23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FR33_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FR43_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FT13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FT23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FT33_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FU13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FU23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FV13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FV33_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FW13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FW23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FZ13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FF25_group(MedicalRecord record){
            return true;
        }
    
        public static bool FF35_group(MedicalRecord record){
            return true;
        }
    
        public static bool FN15_group(MedicalRecord record){
            return true;
        }
    
        public static bool FR15_group(MedicalRecord record){
            return true;
        }
    
        public static bool FR25_group(MedicalRecord record){
            return true;
        }
    
        public static bool FR35_group(MedicalRecord record){
            return true;
        }
    
        public static bool FR45_group(MedicalRecord record){
            return true;
        }
    
        public static bool FT15_group(MedicalRecord record){
            return true;
        }
    
        public static bool FT25_group(MedicalRecord record){
            return true;
        }
    
        public static bool FT35_group(MedicalRecord record){
            return true;
        }
    
        public static bool FU15_group(MedicalRecord record){
            return true;
        }
    
        public static bool FU25_group(MedicalRecord record){
            return true;
        }
    
        public static bool FV15_group(MedicalRecord record){
            return true;
        }
    
        public static bool FV35_group(MedicalRecord record){
            return true;
        }
    
        public static bool FW15_group(MedicalRecord record){
            return true;
        }
    
        public static bool FW25_group(MedicalRecord record){
            return true;
        }
    
        public static bool FZ15_group(MedicalRecord record){
            return true;
        }
    
    }
}
