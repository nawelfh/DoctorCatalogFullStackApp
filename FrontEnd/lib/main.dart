import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:doctor_catalog/screens/pharmacien.dart';
import 'package:doctor_catalog/screens/patient.dart';
import 'package:doctor_catalog/screens/ordonnance.dart';
import 'package:doctor_catalog/screens/medicament.dart';
import 'package:doctor_catalog/screens/add_pharmacien.dart';
import 'package:doctor_catalog/screens/add_patient.dart';
import 'package:doctor_catalog/screens/add_medicament.dart';
import 'package:doctor_catalog/screens/add_ordonnance.dart';

void main() {
  WidgetsFlutterBinding.ensureInitialized();
  SystemChrome.setSystemUIOverlayStyle(SystemUiOverlayStyle(
    statusBarColor: Colors.black.withOpacity(0),
    statusBarIconBrightness: Brightness.dark,
  ));
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
        theme: ThemeData(scaffoldBackgroundColor: const Color(0xFFFFF6F8)),
        title: "Pharmacie",
        debugShowCheckedModeBanner: false,
        // theme: ThemeData(fontFamily: 'Montserrat'),
        initialRoute: '/pharmacie',
        routes: <String, WidgetBuilder>{
          '/pharmacie': (BuildContext context) => const Pharmacien()
        });
  }
}
