export type BowlerTeamInfo = {
  bowlerId: number;
  bowlerLastName: string;
  bowlerFirstName: string;
  bowlerMiddleInit?: string; // Make optional properties nullable
  bowlerAddress?: string;
  bowlerCity?: string;
  bowlerState?: string;
  bowlerZip?: string;
  bowlerPhoneNumber?: string;
  teamId: number;
  teamName: string;
  captainId?: number; // Assuming you included this
};
