import { DepartmentResearche } from "./department-research.model";
import { WorkSchedule } from "./work-schedule.model";

export interface Department {
    Id: number;
    CityID: number;
    CityName: string;
    RegionName: string;
    RegionID: number;
    Street: string;
    Building: string;
    PhoneNumber: string;
    WorkSchedules: WorkSchedule[];
    DepartmentResearches: DepartmentResearche[];
}