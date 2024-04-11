//В11
double k = 0.9;
double g = 9.8;
double dt = 0.1;
int Accel_LSB = 16384;
int Gyro_LSB = 131;

int gyro_x0=49;
int gyro_x=-217;//+
int gyro_y0 = -54;
int gyro_y = 145;
int gyro_z0 = 124;
int gyro_z = 235;
int axy_x0=-1420;//+
int axy_x=-1324;
int axy_y0 = 4488;//+
int axy_y = 4148;
//всегда используем 0!!!
int axy_z0 = -15932;
int axy_z = -16012;

double gx = (double)gyro_x / (double)Gyro_LSB;
double gy = (double)gyro_y / (double)Gyro_LSB;
double gz = (double)gyro_z / (double)Gyro_LSB;

//предыдущие
double AX_X0 = (double)(axy_x0 / (double)Accel_LSB);
double angle_accelx0 = 57.2958 * Math.Acos(AX_X0);

double AY_Y0 = (double)(axy_y0 / (double)Accel_LSB);
double angle_accely0 = 57.2958 * Math.Acos(AY_Y0);

//по Z просто 0
double AZ_Z0 = (double)(axy_y0 / (double)Accel_LSB);
double angle_accelz0 = 0;

double angle_gyroX = angle_accelx0 + gx * dt;
double angle_gyroY = angle_accely0 + gy * dt;
double angle_gyroZ = angle_accelz0 + gz * dt;
Console.WriteLine(angle_gyroX);
Console.WriteLine(angle_gyroY);
Console.WriteLine(angle_gyroZ);
Console.WriteLine("################################");
//текущие
double AX_X = (double)(axy_x / (double)Accel_LSB);
double angle_accelx = 57.2958 * Math.Acos(AX_X);

double AY_Y = (double)(axy_y0 / (double)Accel_LSB);
double angle_accely = 57.2958 * Math.Acos(AY_Y);

//по Z просто 0
double AZ_Z = (double)(axy_y / (double)Accel_LSB);
double angle_accelz = 0;


double angle_x_t = k * angle_gyroX + (1 - k) * angle_accelx;
double angle_y_t = k * angle_gyroY + (1 - k) * angle_accely;
double angle_z_t = k * angle_gyroZ + (1 - k) * angle_accelz;
Console.WriteLine(angle_x_t);
Console.WriteLine(angle_y_t);
Console.WriteLine(angle_z_t);

