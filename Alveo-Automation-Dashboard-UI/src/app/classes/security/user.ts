import { UserRoles } from '../../enums/security/user-roles';

export class User {
  public id: string;
  public name: string
  public password: string;
  public role: UserRoles;
  public token: string;
}
