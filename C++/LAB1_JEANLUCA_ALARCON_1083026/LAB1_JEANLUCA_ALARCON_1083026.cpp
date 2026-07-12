#include "pch.h"
#include <stdlib.h>
#include <iostream>
#include <string>
using namespace System;
using namespace std;

int leerMonto() {
    int monto;
    while (true) {
        cin >> monto;

        if (cin.fail()) {
            cin.clear();
            cin.ignore(100, '\n');
            cout << ("Debe ingresar unicamente numeros: ") << endl;
        }
        else if (monto < 0) {
            cout << " No se permiten negativos" << endl;
        }
        else {
            return monto;
        }
    }
}
void consultarSaldo(int saldo) {
    cout << ("El saldo de tu cuenta es: ") << saldo << endl;
}

void depositarDinero(int& saldo, string historial[], int& operaciones, int& depositos) {
    int deposito;
    while (true) {

        cout << ("Cuanto dinero quieres depositar: ") << endl;
        deposito = leerMonto();

        if (deposito < 1) {
            cout << "El monto minimo es 1.00" << endl;
        }
        else {
            saldo += deposito;
            historial[operaciones] = "Deposito realizado: " + to_string(deposito);
            operaciones++;
            depositos++;
            cout << "Deposito realizado con exito" << endl;
            cout << "Nuevo saldo: " << saldo << endl;
            break;
        }
    }
}

void retirarDinero(int& saldo, string historial[], int& operaciones, int& retiros) {
    int retiro;
    while (true) {
        cout << "Cuanto dinero quieres retirar: " << endl;
        retiro = leerMonto();

        if (retiro < 1) {
            cout << "El retiro debe ser mayor a 1" << endl;
        }
        else if (retiro > saldo) {
            cout << "Su saldo es insuficiente " << endl;
        }
        else {
            saldo -= retiro;
            historial[operaciones] = "Retiro realizado: " + to_string(retiro);
            operaciones++;
            retiros++;
            cout << "Retiro exitoso" << endl;
            cout << "Nuevo saldo: " << saldo << endl;
            break;
        }
    }
}

void transferirDinero(int& saldo, string historial[], int& operaciones, int& transferencias) {
    int transferencia;
    while (true) {
        cout << "Cuanto dinero quieres transferir: " << endl;
        transferencia = leerMonto();

        if (transferencia < 1) {
            cout << "El monto debe ser mayor a 1" << endl;
        }
        else if (transferencia > saldo) {
            cout << "Su saldo es insuficiente " << endl;
        }
        else {
            saldo -= transferencia;
            historial[operaciones] = "Transferencia realizado: " + to_string(transferencia);
            operaciones++;
            transferencias++;
            cout << "Treansferencia exitosa" << endl;
            cout << "Nuevo saldo: " << saldo << endl;
            break;
        }
    }
}

void historia(string historial[], int operaciones) {
    if (operaciones == 0) {
        cout << "No hay historial de operaciones. " << endl;
    }
    else {
        cout << ("HISTORIAL: ") << endl;
        for (int i = 0; i < operaciones; i++) {
            cout << historial[i] << endl;
        }
    }
}

void limpiar() {
    system("pause");
    system("CLS");
}
int main()
{
    int saldo = 5000;
    string historial[100];
    int operaciones = 0;
    int depositos = 0;
    int retiros = 0;
    int transferencias = 0;
    int opcion;
    do {
        cout << ("========== BANCO URL ==========") << endl;
        cout << ("  1. Consultar saldo") << endl;
        cout << ("  2. Depositar dinero") << endl;
        cout << ("  3. Retirar dinero") << endl;
        cout << ("  4. Transferir dinero") << endl;
        cout << ("  5. Ver historial de operaciones") << endl;
        cout << ("  6. Salir") << endl;
        cout << ("Ingrese la opcion deseada") << endl;
        opcion = leerMonto();

        switch (opcion) {
        case 1:
            consultarSaldo(saldo);
            limpiar();
            break;
        case 2:
            depositarDinero(saldo, historial, operaciones, depositos);
            limpiar();
            break;
        case 3:
            retirarDinero(saldo, historial, operaciones, retiros);
            limpiar();
            break;
        case 4:
            transferirDinero(saldo, historial, operaciones, transferencias);
            limpiar();
            break;
        case 5:
            historia(historial, operaciones);
            limpiar();
            break;
        case 6:
            cout << "RESUMEN:" << endl;
            cout << "Saldo final: " << saldo << endl;
            cout << "N.Depositos: " << depositos << endl;
            cout << "N.Retiros: " << retiros << endl;
            cout << "N.Transferencias " << transferencias << endl;
            cout << "Saliendo...";
            break;
        default:
            cout << "Opción no valida" << endl;
            limpiar();

        }
    } while (opcion != 6);
    return 0;
}