import { useEffect, useState } from 'react';
import { BowlerTeamInfo } from '../types/Bowlers';

function BowlerList() {
  const [bowlerData, setBowlerData] = useState<BowlerTeamInfo[]>([]);

  useEffect(() => {
    const fetchBowlerData = async () => {
      const rsp = await fetch('https://localhost:7112/Bowler');
      const f = await rsp.json();
      setBowlerData(f);
    };
    fetchBowlerData();
  }, []);

  return (
    <>
      <div className="row">
        <h4 className="text-center">Bowlers</h4>
      </div>
      <table className="table table-bordered">
        <thead>
          <tr>
            <th>Name</th>
            <th>Team Name</th>
            <th>Address</th>
            <th>City</th>
            <th>State</th>
            <th>Zip</th>
            <th>Phone Number</th>
          </tr>
        </thead>
        <tbody>
          {bowlerData.map((f) => {
            return (
              <tr key={f.bowlerId}>
                <td>
                  {f.bowlerFirstName} {f.bowlerMiddleInit} {f.bowlerLastName}
                </td>
                <td>{f.teamName}</td>
                <td>{f.bowlerAddress}</td>
                <td>{f.bowlerCity}</td>
                <td>{f.bowlerState}</td>
                <td>{f.bowlerZip}</td>
                <td>{f.bowlerPhoneNumber}</td>
              </tr>
            );
          })}
        </tbody>
      </table>
    </>
  );
}

export default BowlerList;
