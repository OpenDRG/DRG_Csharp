namespace drg_group.beijing_2022
{
    public class MDCR_DRG 
    {
    
        public static bool RA39_group(MedicalRecord record){
            return true;
        }
    
        public static bool RG19_group(MedicalRecord record){
            return true;
        }
    
        public static bool RA49_group(MedicalRecord record){
            return true;
        }
    
        public static bool RT29_group(MedicalRecord record){
            return true;
        }
    
        public static bool RW11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool RW21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool RR11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool RA21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool RB11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool RB21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool RU11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool RD11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool RT11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool RS11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool RA11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool RA23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool RS13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool RS23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool RR13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool RS15_group(MedicalRecord record){
            return true;
        }
    
        public static bool RA15_group(MedicalRecord record){
            return true;
        }
    
        public static bool RB25_group(MedicalRecord record){
            return true;
        }
    
        public static bool RW25_group(MedicalRecord record){
            return true;
        }
    
        public static bool RB15_group(MedicalRecord record){
            return true;
        }
    
        public static bool RU15_group(MedicalRecord record){
            return true;
        }
    
        public static bool RA25_group(MedicalRecord record){
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
    
        public static bool RD15_group(MedicalRecord record){
            return true;
        }
    
        public static bool RR15_group(MedicalRecord record){
            return true;
        }
    
        public static bool RC12_group(MedicalRecord record){
            return record.inHospitalTime>=13;
        }
    
        public static bool RC14_group(MedicalRecord record){
            return record.inHospitalTime>=6 && record.inHospitalTime<13;
        }
    
        public static bool RC16_group(MedicalRecord record){
            return record.inHospitalTime>=2 && record.inHospitalTime<6;
        }
    
        public static bool RC18_group(MedicalRecord record){
            return record.inHospitalTime==1;
        }
    
        public static bool RC22_group(MedicalRecord record){
            return record.inHospitalTime>=14;
        }
    
        public static bool RC24_group(MedicalRecord record){
            return record.inHospitalTime>=7 && record.inHospitalTime<14;
        }
    
        public static bool RC26_group(MedicalRecord record){
            return record.inHospitalTime>=3 && record.inHospitalTime<7;
        }
    
        public static bool RC28_group(MedicalRecord record){
            return record.inHospitalTime>=1 && record.inHospitalTime<3;
        }
    
        public static bool RE12_group(MedicalRecord record){
            return record.inHospitalTime>=14;
        }
    
        public static bool RE14_group(MedicalRecord record){
            return record.inHospitalTime>=7 && record.inHospitalTime<14;
        }
    
        public static bool RE16_group(MedicalRecord record){
            return record.inHospitalTime>=1 && record.inHospitalTime<7;
        }
    
    }
}
