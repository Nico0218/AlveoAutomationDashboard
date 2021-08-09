import { ObjectStatus } from '../enums/config/object-status';

export abstract class ObjectBase {
  public id!: string;
  public name!: string;
  public displayName!: string;
  public status!: ObjectStatus;
}
