export interface Training {
    Tid: number;
    Description: string | null;
    Video: ArrayBuffer | null;
    Image: ArrayBuffer | null;
    Tname: string | null;
    Category: string | null;
    Logo: ArrayBuffer | null;
    CreatedBy: string | null;
    Duration: string | null;
    Resources: string | null;
  }
  export interface Reviews {
    rId: number;
    rname: string;
    rating: number;
    createdAt: string;
    description: string;
    traningId: number | null;
    userId: number | null;
    courseId: number | null;
  }
  
  