import { WeekDay } from "@angular/common";
import { DayOfWeek } from "./DayWeek.model";

export class WorkSchedule {
    Id: number;
    DayOfWeek: DayOfWeek;
    StartTime: string;
    EndTime: string;
}