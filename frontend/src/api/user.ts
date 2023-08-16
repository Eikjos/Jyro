import { RegisterRequestType } from '../types/User';
import { client } from './client';

export const register = (json: RegisterRequestType) => client.post<void>('users/register', json).then((r) => r.data);
