namespace drg_group.changzhou_2022
{
    public class MDCR_DRG 
    {
    
        public static bool RW10_group(MedicalRecord record){
            return record.age<=17;
        }
    
        public static bool RA19_group(MedicalRecord record){
            return true;
        }
    
        public static bool RA49_group(MedicalRecord record){
            return true;
        }
    
        public static bool RB19_group(MedicalRecord record){
            return true;
        }
    
        public static bool RC19_group(MedicalRecord record){
            return true;
        }
    
        public static bool RD19_group(MedicalRecord record){
            return true;
        }
    
        public static bool RE19_group(MedicalRecord record){
            return true;
        }
    
        public static bool RF19_group(MedicalRecord record){
            return true;
        }
    
        public static bool RT29_group(MedicalRecord record){
            return true;
        }
    
        public static bool RU29_group(MedicalRecord record){
            return true;
        }
    
        public static bool RV19_group(MedicalRecord record){
            return true;
        }
    
        public static bool RA21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool RA31_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool RR11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool RS11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool RS21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool RT11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool RW21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool RA23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool RA33_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool RR13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool RS13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool RS23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool RT13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool RW13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool RW23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool RA25_group(MedicalRecord record){
            return true;
        }
    
        public static bool RA35_group(MedicalRecord record){
            return true;
        }
    
        public static bool RR15_group(MedicalRecord record){
            return true;
        }
    
        public static bool RS15_group(MedicalRecord record){
            return true;
        }
    
        public static bool RS25_group(MedicalRecord record){
            return true;
        }
    
        public static bool RT15_group(MedicalRecord record){
            return true;
        }
    
        public static bool RW15_group(MedicalRecord record){
            return true;
        }
    
        public static bool RW25_group(MedicalRecord record){
            return true;
        }
    
        public static bool RU10_group(MedicalRecord record){
            return record.inHospitalTime<=7;
        }
    
        public static bool RU12_group(MedicalRecord record){
            return record.inHospitalTime>7 && record.inHospitalTime<=30;
        }
    
        public static bool RU14_group(MedicalRecord record){
            return record.inHospitalTime>30 && record.inHospitalTime<=60;
        }
    
    }
}
