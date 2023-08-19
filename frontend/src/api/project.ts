import { client } from "@api/client";
import { CreateProjectRequest, Project } from "@type/Project";

export const getProjectByUser = (token : string) => client.get<Project[]>('projects', { 
  Headers: { Authorization: 'Bearer ' + token}}).then(r => r.data);

export const createProject = (json: CreateProjectRequest, token: string) => client.post<Project>('projects', {
  Headers: { Authorization: 'Bearer ' + token}}).then(r => r.data);