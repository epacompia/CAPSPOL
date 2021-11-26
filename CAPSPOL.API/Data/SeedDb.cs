using CAPSPOL.API.Data.Entities;
using CAPSPOL.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CAPSPOL.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }
        //ALGO MAS CAUSA
        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();  //si es que la bd no existe la craera
            await CheckGradesAsync();
            await CheckPoliceStationsAsync();
            await CheckPositionsAsync();
            await CheckSpecialitiesAsync();
            await CheckSubUnitsAsync();

            await ChekcRolesAsync();
            await ChekUserAsync("Eduardo Natalio","Pacompia","Lopez","Masculino","Mz 2 Lt 3 Villa de Jesus Villa el salvador",43908196,"953553770","2782550",DateTime.Now,"eduardopacompialopez@policia.gob.pe","eduardopacompialopez@gmail.com","CASADO", DateTime.Now, UserType.Admin,true);
            await ChekUserAsync("Eduardo Natalio", "Pacompia", "Lopez", "Masculino", "Mz 2 Lt 3 Villa de Jesus Villa el salvador", 43908196, "953553770", "2782550", DateTime.Now, "eduardopacompialopez@policia.gob.pe", "eduardopacompialopez@gmail.com", "CASADO",  DateTime.Now, UserType.User, true);
            await ChekUserAsync("Eduardo Natalio", "Pacompia", "Lopez", "Masculino", "Mz 2 Lt 3 Villa de Jesus Villa el salvador", 43908196, "953553770", "2782550", DateTime.Now, "eduardopacompialopez@policia.gob.pe", "eduardopacompialopez@gmail.com", "CASADO", DateTime.Now, UserType.User, true);


        }



        //LLENANDO SUBUNIT
        private async Task CheckSubUnitsAsync()
        {
            if (!_context.SubUnits.Any())
            {
                _context.SubUnits.Add(new SubUnit { Name= "AYUDANTIA", Description= "Sub Unidad de la DIRCOCOR", Flag=true});
                _context.SubUnits.Add(new SubUnit { Name = "DEPDICAP CALLAO", Description = "Sub Unidad de la DIRCOCOR", Flag = true });
                _context.SubUnits.Add(new SubUnit { Name = "DEPDICAP LIMA ESTE", Description = "Sub Unidad de la DIRCOCOR", Flag = true });
                _context.SubUnits.Add(new SubUnit { Name = "DEPDICAP LIMA NORTE", Description = "Sub Unidad de la DIRCOCOR", Flag = true });
                _context.SubUnits.Add(new SubUnit { Name = "DEPDICAP LIMA SUR", Description = "Sub Unidad de la DIRCOCOR", Flag = true });
                _context.SubUnits.Add(new SubUnit { Name = "DEPDICAP AMAZONAS", Description = "Sub Unidad de la DIRCOCOR", Flag = true });
                _context.SubUnits.Add(new SubUnit { Name = "DEPDICAP APURIMAC", Description = "Sub Unidad de la DIRCOCOR", Flag = true });
                _context.SubUnits.Add(new SubUnit { Name = "DEPDICAP AREQUIPA", Description = "Sub Unidad de la DIRCOCOR", Flag = true });
                _context.SubUnits.Add(new SubUnit { Name = "DEPDICAP AYACUCHO", Description = "Sub Unidad de la DIRCOCOR", Flag = true });
                _context.SubUnits.Add(new SubUnit { Name = "DEPDICAP CAJAMARCA", Description = "Sub Unidad de la DIRCOCOR", Flag = true });
                _context.SubUnits.Add(new SubUnit { Name = "DEPDICAP CERRO DE PASCO", Description = "Sub Unidad de la DIRCOCOR", Flag = true });
                _context.SubUnits.Add(new SubUnit { Name = "DEPDICAP CHICLAYO", Description = "Sub Unidad de la DIRCOCOR", Flag = true });
                _context.SubUnits.Add(new SubUnit { Name = "DEPDICAP CHIMBOTE", Description = "Sub Unidad de la DIRCOCOR", Flag = true });
                _context.SubUnits.Add(new SubUnit { Name = "DEPDICAP CUSCO", Description = "Sub Unidad de la DIRCOCOR", Flag = true });
                _context.SubUnits.Add(new SubUnit { Name = "DEPDICAP HUANCAVELICA", Description = "Sub Unidad de la DIRCOCOR", Flag = true });
                _context.SubUnits.Add(new SubUnit { Name = "DEPDICAP HUANCAYO", Description = "Sub Unidad de la DIRCOCOR", Flag = true });
                _context.SubUnits.Add(new SubUnit { Name = "DEPDICAP HUANUCO", Description = "Sub Unidad de la DIRCOCOR", Flag = true });
                _context.SubUnits.Add(new SubUnit { Name = "DEPDICAP HUARAZ", Description = "Sub Unidad de la DIRCOCOR", Flag = true });
                _context.SubUnits.Add(new SubUnit { Name = "DEPDICAP ICA", Description = "Sub Unidad de la DIRCOCOR", Flag = true });
                _context.SubUnits.Add(new SubUnit { Name = "DEPDICAP IQUITOS", Description = "Sub Unidad de la DIRCOCOR", Flag = true });
                _context.SubUnits.Add(new SubUnit { Name = "DEPDICAP MADRE DE DIOS", Description = "Sub Unidad de la DIRCOCOR", Flag = true });
                _context.SubUnits.Add(new SubUnit { Name = "DEPDICAP MOQUEGUA", Description = "Sub Unidad de la DIRCOCOR", Flag = true });
                _context.SubUnits.Add(new SubUnit { Name = "DEPDICAP MOYOBAMBA", Description = "Sub Unidad de la DIRCOCOR", Flag = true });
                _context.SubUnits.Add(new SubUnit { Name = "DEPDICAP PIURA", Description = "Sub Unidad de la DIRCOCOR", Flag = true });
                _context.SubUnits.Add(new SubUnit { Name = "DEPDICAP PUNO", Description = "Sub Unidad de la DIRCOCOR", Flag = true });
                _context.SubUnits.Add(new SubUnit { Name = "DEPDICAP TACNA", Description = "Sub Unidad de la DIRCOCOR", Flag = true });
                _context.SubUnits.Add(new SubUnit { Name = "DEPDICAP TRUJILLO", Description = "Sub Unidad de la DIRCOCOR", Flag = true });
                _context.SubUnits.Add(new SubUnit { Name = "DEPDICAP TUMBES", Description = "Sub Unidad de la DIRCOCOR", Flag = true });
                _context.SubUnits.Add(new SubUnit { Name = "DEPDICAP UCAYALI", Description = "Sub Unidad de la DIRCOCOR", Flag = true });
                _context.SubUnits.Add(new SubUnit { Name = "DIRECCION", Description = "Sub Unidad de la DIRCOCOR", Flag = true });
                _context.SubUnits.Add(new SubUnit { Name = "DIVIDCAP", Description = "Sub Unidad de la DIRCOCOR", Flag = true });
                _context.SubUnits.Add(new SubUnit { Name = "DIVIDCVCO", Description = "Sub Unidad de la DIRCOCOR", Flag = true });
                _context.SubUnits.Add(new SubUnit { Name = "DIVINANT", Description = "Sub Unidad de la DIRCOCOR", Flag = true });
                _context.SubUnits.Add(new SubUnit { Name = "DIVPEICC", Description = "Sub Unidad de la DIRCOCOR", Flag = true });
                _context.SubUnits.Add(new SubUnit { Name = "JEFDDICC", Description = "Sub Unidad de la DIRCOCOR", Flag = true });
                _context.SubUnits.Add(new SubUnit { Name = "OFAD", Description = "Sub Unidad de la DIRCOCOR", Flag = true });
                _context.SubUnits.Add(new SubUnit { Name = "SECRETARIA", Description = "Sub Unidad de la DIRCOCOR", Flag = true });
                _context.SubUnits.Add(new SubUnit { Name = "UNIASJUR", Description = "Sub Unidad de la DIRCOCOR", Flag = true });
                _context.SubUnits.Add(new SubUnit { Name = "UNICI", Description = "Sub Unidad de la DIRCOCOR", Flag = true });
                _context.SubUnits.Add(new SubUnit { Name = "UNICRI", Description = "Sub Unidad de la DIRCOCOR", Flag = true });
                _context.SubUnits.Add(new SubUnit { Name = "UNIPLEDU", Description = "Sub Unidad de la DIRCOCOR", Flag = true });
                _context.SubUnits.Add(new SubUnit { Name = "UNISEINS", Description = "Sub Unidad de la DIRCOCOR", Flag = true });
                _context.SubUnits.Add(new SubUnit { Name = "UNITIC", Description = "Sub Unidad de la DIRCOCOR", Flag = true });
                _context.SubUnits.Add(new SubUnit { Name = "UNITRDOC", Description = "Sub Unidad de la DIRCOCOR", Flag = true });
                await _context.SaveChangesAsync();
            }
        }


        //LLENANDO SPECIALITY
        private async Task CheckSpecialitiesAsync()
        {
            if (!_context.Specialities.Any())
            {
                _context.Specialities.Add(new Speciality { Name = "ADMINISTRATIVO", Description = "Personal administrativo de la DIRCOCOR", Flag = true });
                _context.Specialities.Add(new Speciality { Name = "ASISTENTE ADMINISTRATIVO", Description = "Personal designado de la DIRCOCOR", Flag = true });
                _context.Specialities.Add(new Speciality { Name = "CONTRATADOS", Description = "Personal contratados de la DIRCOCOR", Flag = true });
                _context.Specialities.Add(new Speciality { Name = "OPERATIVO", Description = "Personal operativo de la DIRCOCOR", Flag = true });
                await _context.SaveChangesAsync();
            }
        }

        //LLENANDO POSITION
        private async Task CheckPositionsAsync()
        {
            if (!_context.Positions.Any())
            {
                _context.Positions.Add(new Position {Name= "Adaptacion Civil", Description= "Adaptacion Civil", Flag=true });
                _context.Positions.Add(new Position { Name = "Agente de Protección", Description = "Agente de Protección", Flag = true });
                _context.Positions.Add(new Position { Name = "Agente de Protección/Chofer", Description = "Agente de Protección/Chofer", Flag = true });
                _context.Positions.Add(new Position { Name = "Agente de Inteligencia", Description = "Agente de Inteligencia", Flag = true });
                _context.Positions.Add(new Position { Name = "Armamento y Municiones/Transportes", Description = "Armamento y Municiones/Transportes", Flag = true });
                _context.Positions.Add(new Position { Name = "Asist. Administrativo", Description = "Asist. Administrativo", Flag = true });
                _context.Positions.Add(new Position { Name = "Asist. Contable", Description = "Asist. Contable", Flag = true });
                _context.Positions.Add(new Position { Name = "Asist. Tec. Economia", Description = "Asist. Tec. Economia", Flag = true });
                _context.Positions.Add(new Position { Name = "Asistente Social", Description = "Asistente Social", Flag = true });
                _context.Positions.Add(new Position { Name = "Asistente", Description = "Asistente", Flag = true });
                _context.Positions.Add(new Position { Name = "Asistente de Comunicacion Social", Description = "Asistente de Comunicacion Social", Flag = true });
                _context.Positions.Add(new Position { Name = "ASO (LACTANCIA)", Description = "ASO (LACTANCIA)", Flag = true });
                _context.Positions.Add(new Position { Name = "Aux. Contable", Description = "Aux. Contable", Flag = true });
                _context.Positions.Add(new Position { Name = "Chofer", Description = "Chofer", Flag = true });
                _context.Positions.Add(new Position { Name = "Conservador de Ambiente", Description = "Conservador de Ambiente", Flag = true });
                _context.Positions.Add(new Position { Name = "Contador", Description = "Contador", Flag = true });
                _context.Positions.Add(new Position { Name = "Contadora Pública", Description = "Contadora Pública", Flag = true });
                _context.Positions.Add(new Position { Name = "Correspondencia", Description = "Correspondencia", Flag = true });
                _context.Positions.Add(new Position { Name = "Director", Description = "Director", Flag = true });
                _context.Positions.Add(new Position { Name = "Documentaria", Description = "Documentaria", Flag = true });
                _context.Positions.Add(new Position { Name = "Documentario", Description = "Documentario", Flag = true });
                _context.Positions.Add(new Position { Name = "Investigador", Description = "Investigador", Flag = true });
                _context.Positions.Add(new Position { Name = "Investigador/Chofer", Description = "Investigador/Chofer", Flag = true });
                _context.Positions.Add(new Position { Name = "Investigador/Documentario", Description = "Investigador/Documentario", Flag = true });
                _context.Positions.Add(new Position { Name = "Investigador/Mesa Partes", Description = "Investigador/Mesa Partes", Flag = true });
                _context.Positions.Add(new Position { Name = "Jefe Modernizacion y Desa.", Description = "Jefe Modernizacion y Desa.", Flag = true });
                _context.Positions.Add(new Position { Name = "Jefe Planeamiento Op.y Adm", Description = "Jefe Planeamiento Op.y Adm", Flag = true });
                _context.Positions.Add(new Position { Name = "Jefe de Departamento", Description = "Jefe de Departamento", Flag = true });
                _context.Positions.Add(new Position { Name = "Jefe de Departamento(e)", Description = "Jefe de Departamento(e)", Flag = true });
                _context.Positions.Add(new Position { Name = "Jefe de División", Description = "Jefe de División", Flag = true });
                _context.Positions.Add(new Position { Name = "Jefe de Equipo", Description = "Jefe de Equipo", Flag = true });
                _context.Positions.Add(new Position { Name = "Jefe Eq.N°1 Control y Sup.", Description = "Jefe Eq.N°1 Control y Sup.", Flag = true });
                _context.Positions.Add(new Position { Name = "Jefe Eq.N°2 Control y Sup.", Description = "Jefe Eq.N°2 Control y Sup.", Flag = true });
                _context.Positions.Add(new Position { Name = "Jefe de Ofad", Description = "Jefe de Ofad", Flag = true });
                _context.Positions.Add(new Position { Name = "Jefe Dep. Cont. y Fin.", Description = "Jefe Dep. Cont. y Fin.", Flag = true });
                _context.Positions.Add(new Position { Name = "Jefe Dep. Graf. Forense", Description = "Jefe Dep. Graf. Forense", Flag = true });
                _context.Positions.Add(new Position { Name = "Jefe Unid. Tram. Documentario", Description = "Jefe Unid. Tram. Documentario", Flag = true });
                _context.Positions.Add(new Position { Name = "Moral Disciplina", Description = "Moral Disciplina", Flag = true });
                _context.Positions.Add(new Position { Name = "Oficial de Investigación", Description = "Oficial de Investigación", Flag = true });
                _context.Positions.Add(new Position { Name = "Oficial Inteligencia", Description = "Oficial Inteligencia", Flag = true });
                _context.Positions.Add(new Position { Name = "Perito Grafotecnico", Description = "Perito Grafotecnico", Flag = true });
                _context.Positions.Add(new Position { Name = "Secretario", Description = "Secretario", Flag = true });
                _context.Positions.Add(new Position { Name = "Seguridad", Description = "Seguridad", Flag = true });
                _context.Positions.Add(new Position { Name = "Seguridad de Instalaciones", Description = "Seguridad de Instalaciones", Flag = true });
                _context.Positions.Add(new Position { Name = "Seguridad Testigo Eficaz", Description = "Seguridad Testigo Eficaz", Flag = true });
                _context.Positions.Add(new Position { Name = "Seguridad/Secretaria", Description = "Seguridad/Secretaria", Flag = true });
                _context.Positions.Add(new Position { Name = "Técnico Administrativo", Description = "Técnico Administrativo", Flag = true });
                _context.Positions.Add(new Position { Name = "Técnico Computo", Description = "Técnico Computo", Flag = true });
                _context.Positions.Add(new Position { Name = "Transporte", Description = "Transporte", Flag = true });
                _context.Positions.Add(new Position { Name = "UNIECO/Asistente Administrativo", Description = "UNIECO/Asistente Administrativo", Flag = true });
                _context.Positions.Add(new Position { Name = "UNIECO/ROUD", Description = "UNIECO/ROUD", Flag = true });
                _context.Positions.Add(new Position { Name = "UNIREHUM/Control Personal", Description = "UNIREHUM/Control Personal", Flag = true });
                _context.Positions.Add(new Position { Name = "UNIREHUM/Movimiento Personal", Description = "UNIREHUM/Movimiento Personal", Flag = true });
                await _context.SaveChangesAsync();

            }
        }


        //LLENANDO POLICESTATIONS
        private async Task CheckPoliceStationsAsync()
        {
            if (!_context.PoliceStations.Any())
            {
                _context.PoliceStations.Add(new PoliceStation { Name = "Comisaria Lurin", Flag = true });
                _context.PoliceStations.Add(new PoliceStation { Name = "Comisaria Surco", Flag = true });
                _context.PoliceStations.Add(new PoliceStation { Name = "Comisaria Lince", Flag = true });
                _context.PoliceStations.Add(new PoliceStation { Name = "Comisaria Villa el Salvador", Flag = true });
                _context.PoliceStations.Add(new PoliceStation { Name = "Comisaria Santa Maria", Flag = true });
                await _context.SaveChangesAsync();
            }
        }

        //LLENANDO GRADES
        private async Task CheckGradesAsync()
        {
            if (!_context.Grades.Any())
            {
                _context.Grades.Add(new Grade { Name = "CAP", Description = "Capitan",Flag=true });
                _context.Grades.Add(new Grade { Name = "CMDTE", Description = "Comandante", Flag = true });
                _context.Grades.Add(new Grade { Name = "CRNL", Description = "Coronel", Flag = true });
                _context.Grades.Add(new Grade { Name = "CRNL.S.", Description = "Coronel de Servicios", Flag = true });
                _context.Grades.Add(new Grade { Name = "EC.CAS.", Description = "Empleado Civil", Flag = true });
                _context.Grades.Add(new Grade { Name= "MAY", Description= "Mayor", Flag=true });
                _context.Grades.Add(new Grade { Name = "MAY.S", Description = "Mayor de Servicios", Flag = true });
                _context.Grades.Add(new Grade { Name = "S1", Description = "Sub Oficial de 1°", Flag = true });
                _context.Grades.Add(new Grade { Name = "S2", Description = "Sub Oficial de 2°", Flag = true });
                _context.Grades.Add(new Grade { Name = "S3", Description = "Sub Oficial de 3°", Flag = true });
                _context.Grades.Add(new Grade { Name = "SB S.", Description = "Sub Oficial Brigadier", Flag = true });
                _context.Grades.Add(new Grade { Name = "SS", Description = "Superior", Flag = true });
                _context.Grades.Add(new Grade { Name = "SS S.", Description = "Superior de Servicios", Flag = true });
                _context.Grades.Add(new Grade { Name = "ST1", Description = "Sub Oficial Tecnico de 1°", Flag = true });
                _context.Grades.Add(new Grade { Name = "ST2", Description = "Sub Oficial Tecnico de 2°", Flag = true });
                _context.Grades.Add(new Grade { Name = "ST3", Description = "Sub Oficial Tecnico de 3°", Flag = true });
                await _context.SaveChangesAsync();
            }
        }
    }
}
