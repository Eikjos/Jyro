export type Project = {
  id: string;
  name: string;
  description: string;
}

export type CreateProjectRequest = {
  name: string;
  description: string;
}