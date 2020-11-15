import { IBase } from "./base";
import { RoleType } from "./roleType";

export interface IUser extends IBase{
    firstName: string,
    lastName: string,
    userName: string,
    email: string,
    password: string,
    role:RoleType
}