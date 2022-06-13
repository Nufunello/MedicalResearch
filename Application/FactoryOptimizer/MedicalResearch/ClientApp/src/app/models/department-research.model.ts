import { DepartmentResearchWorkSchedule } from "./department-work-schedule.model";
import { Research } from "./research.model";

export interface DepartmentResearche {
    ID: number;
    ResearchID: number;
    Cabinet: number;
    Research: Research;
    WorkSchedule: DepartmentResearchWorkSchedule;
}